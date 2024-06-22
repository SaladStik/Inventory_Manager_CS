using Inventory.DB_Interaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class History : Form
    {
        private DB_Integrator _dbIntegrator;
        private DataTable _historyDataTable;
        private List<Tuple<int, string>> _locations;
        private bool _isUpdatingLocation = false;

        public History(int productId, DataTable dataTable)
        {
            InitializeComponent();
            _dbIntegrator = new DB_Integrator();
            _historyDataTable = dataTable;
            historyDataGridView.DataSource = _historyDataTable;
            searchHistoryButton.Click += SearchHistoryButton_Click;
            historyDataGridView.CellValueChanged += HistoryDataGridView_CellValueChanged;
            historyDataGridView.EditingControlShowing += HistoryDataGridView_EditingControlShowing;
            historyDataGridView.CellDoubleClick += HistoryDataGridView_CellDoubleClick;
            LoadLocationsAsync().Wait();
            InitializeLocationComboBoxColumn();
            RenameColumns();

            LoadHistoryDataAsync(productId).Wait();
        }

        private void RenameColumns()
        {
            if (_historyDataTable.Columns.Contains("tkt_num"))
            {
                _historyDataTable.Columns["tkt_num"].ColumnName = "Tkt #";
            }
            if (_historyDataTable.Columns.Contains("note"))
            {
                _historyDataTable.Columns["note"].ColumnName = "Note";
            }
        }

        private async Task LoadLocationsAsync()
        {
            string query = "SELECT id, name FROM location";
            DataTable dataTable = await new DB_Integrator().GetDataTableAsync(query, null);
            _locations = dataTable.AsEnumerable().Select(row => new Tuple<int, string>(row.Field<int>("id"), row.Field<string>("name"))).ToList();
        }

        private void InitializeLocationComboBoxColumn()
        {
            var comboBoxColumn = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "location_name",
                HeaderText = "Location",
                DataSource = _locations,
                DisplayMember = "Item2",
                ValueMember = "Item2",
                FlatStyle = FlatStyle.Flat,
                Name = "location_name"
            };
            historyDataGridView.Columns.Remove("location_name");
            historyDataGridView.Columns.Add(comboBoxColumn);
        }

        private void SearchHistoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = searchHistory.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    var filteredRows = _historyDataTable.AsEnumerable()
                        .Where(row =>
                            row.Field<string>("serial_number")?.ToLower().Contains(searchTerm) == true
                            || row.Field<string>("Tkt #")?.ToLower().Contains(searchTerm) == true
                            || row.Field<string>("Note")?.ToLower().Contains(searchTerm) == true
                            || row.Field<string>("location_name")?.ToLower().Contains(searchTerm) == true
                        ).ToList();

                    if (filteredRows.Any())
                    {
                        historyDataGridView.DataSource = filteredRows.CopyToDataTable();
                    }
                    else
                    {
                        MessageBox.Show("No results found.");
                        historyDataGridView.DataSource = _historyDataTable;
                    }
                }
                else
                {
                    historyDataGridView.DataSource = _historyDataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during search: {ex.Message}");
                Console.WriteLine(ex);
            }
        }

        private async void HistoryDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_isUpdatingLocation) return;

                var row = historyDataGridView.Rows[e.RowIndex];
                int historyId = Convert.ToInt32(row.Cells["id"].Value);

                if (e.ColumnIndex == historyDataGridView.Columns["Note"].Index)
                {
                    string newNote = row.Cells["Note"].Value.ToString();
                    string updateNoteQuery = $"UPDATE history SET note = '{newNote}' WHERE id = {historyId}";
                    await new DB_Integrator().QueryAsync(updateNoteQuery, null);
                }

                if (e.ColumnIndex == historyDataGridView.Columns["Tkt #"].Index)
                {
                    string newTicketNum = row.Cells["Tkt #"].Value.ToString();
                    string updateTicketNumQuery = $"UPDATE history SET ticket_num = '{newTicketNum}' WHERE id = {historyId}";
                    await new DB_Integrator().QueryAsync(updateTicketNumQuery, null);
                }

                if (e.ColumnIndex == historyDataGridView.Columns["location_name"].Index && e.RowIndex >= 0)
                {
                    _isUpdatingLocation = true;

                    string newLocationName = row.Cells["location_name"].Value.ToString();
                    int newLocationId = _locations.FirstOrDefault(l => l.Item2 == newLocationName)?.Item1 ?? -1;

                    if (newLocationId == -1)
                    {
                        //MessageBox.Show("Selected location is invalid.");
                        _isUpdatingLocation = false;
                        return;
                    }

                    // Verify if the new location ID exists in the location table
                    string verifyLocationQuery = $"SELECT COUNT(*) FROM location WHERE id = {newLocationId}";
                    object result = await new DB_Integrator().SelectAsync(verifyLocationQuery, null);

                    if (result == null || Convert.ToInt32(result) == 0)
                    {
                        //MessageBox.Show("Selected location does not exist.");
                        _isUpdatingLocation = false;
                        return;
                    }

                    string updateLocationQuery = $"UPDATE history SET id_location = {newLocationId} WHERE id = {historyId}";
                    await new DB_Integrator().QueryAsync(updateLocationQuery, null);

                    _isUpdatingLocation = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                Console.WriteLine(ex);
            }
        }

        private void HistoryDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                if (historyDataGridView.CurrentCell.ColumnIndex == historyDataGridView.Columns["location_name"].Index)
                {
                    if (e.Control is ComboBox comboBox)
                    {
                        comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                        comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                        comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                        comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                Console.WriteLine(ex);
            }
        }

        private async void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_isUpdatingLocation) return;

                if (sender is ComboBox comboBox && historyDataGridView.CurrentCell != null)
                {
                    if (comboBox.SelectedItem == null) return;

                    _isUpdatingLocation = true;

                    int rowIndex = historyDataGridView.CurrentCell.RowIndex;
                    var row = historyDataGridView.Rows[rowIndex];
                    int historyId = Convert.ToInt32(row.Cells["id"].Value);
                    string newLocationName = comboBox.SelectedItem.ToString();
                    int newLocationId = _locations.FirstOrDefault(l => l.Item2 == newLocationName)?.Item1 ?? -1;

                    // Verify if the new location ID exists in the location table
                    string verifyLocationQuery = $"SELECT COUNT(*) FROM location WHERE id = {newLocationId}";
                    object result = await new DB_Integrator().SelectAsync(verifyLocationQuery, null);

                    if (result == null || Convert.ToInt32(result) == 0)
                    {
                        //MessageBox.Show("Selected location does not exist.");
                        _isUpdatingLocation = false;
                        return;
                    }

                    string updateLocationQuery = $"UPDATE history SET id_location = {newLocationId} WHERE id = {historyId}";
                    await new DB_Integrator().QueryAsync(updateLocationQuery, null);

                    _isUpdatingLocation = false;

                    // Clear the current selection
                    historyDataGridView.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                Console.WriteLine(ex);
            }
        }

        private void HistoryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    bool noteColumnExists = historyDataGridView.Columns.Contains("Note");
                    bool tktNumColumnExists = historyDataGridView.Columns.Contains("Tkt #");

                    if ((noteColumnExists && e.ColumnIndex == historyDataGridView.Columns["Note"].Index) ||
                        (tktNumColumnExists && e.ColumnIndex == historyDataGridView.Columns["Tkt #"].Index))
                    {
                        historyDataGridView.BeginEdit(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadHistoryDataAsync(int productId)
        {
            try
            {
                string query = $"SELECT h.id, h.id_product, l.name AS location_name, h.serial_number, h.date, h.note AS Note, h.ticket_num AS \"Tkt #\" FROM history h JOIN location l ON h.id_location = l.id WHERE h.id_product = {productId} ORDER BY h.id ASC";
                DataTable historyTable = await _dbIntegrator.GetDataTableAsync(query, null);
                historyDataGridView.DataSource = historyTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
