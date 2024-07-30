using Inventory.DB_Interaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private List<string> _serialNumbersToPrint;
        private DateTime _selectedStartDate;
        private DateTime _selectedEndDate;
        private bool _printFullTable;
        private bool _isPrintDialogOpen = false; // Flag to prevent print dialog from opening twice
        bool isAdmin = UserSession.Role == "Administrator";
        bool isUser = UserSession.Role == "User";
        bool isViewer = UserSession.Role == "Viewer";

        public History(int productId, DataTable dataTable)
        {
            InitializeComponent();
            _dbIntegrator = new DB_Integrator();
            _historyDataTable = dataTable;
            RenameColumns(); // Rename columns before setting the DataSource
            historyDataGridView.DataSource = _historyDataTable;

            UnsubscribeEventHandlers(); // Unsubscribe from all event handlers
            SubscribeEventHandlers(); // Subscribe to all event handlers

            LoadLocationsAsync().Wait();
            InitializeLocationComboBoxColumn();

            LoadHistoryDataAsync(productId).Wait();

            // Set the DataGridView and controls to read-only if the user is a viewer
            if (isViewer)
            {
                historyDataGridView.ReadOnly = true;
                searchHistoryButton.Enabled = true;
                Print.Enabled = true;
                startDate.Enabled = true;
                endDate.Enabled = true;
            }
        }


        private void UnsubscribeEventHandlers()
        {
            searchHistoryButton.Click -= SearchHistoryButton_Click;
            Print.Click -= Print_Click;
            historyDataGridView.CellValueChanged -= HistoryDataGridView_CellValueChanged;
            historyDataGridView.EditingControlShowing -= HistoryDataGridView_EditingControlShowing;
            historyDataGridView.CellDoubleClick -= HistoryDataGridView_CellDoubleClick;
        }

        private void SubscribeEventHandlers()
        {
            searchHistoryButton.Click += SearchHistoryButton_Click;
            Print.Click += Print_Click;

            if (!isViewer)
            {
                historyDataGridView.CellValueChanged += HistoryDataGridView_CellValueChanged;
                historyDataGridView.EditingControlShowing += HistoryDataGridView_EditingControlShowing;
                historyDataGridView.CellDoubleClick += HistoryDataGridView_CellDoubleClick;
            }
        }


        private void RenameColumns()
        {
            if (_historyDataTable.Columns.Contains("ticket_num"))
            {
                _historyDataTable.Columns["ticket_num"].ColumnName = "Tkt #";
            }
            if (_historyDataTable.Columns.Contains("note"))
            {
                _historyDataTable.Columns["note"].ColumnName = "Note";
            }
        }

        private async Task LoadLocationsAsync()
        {
            string query = "SELECT id, name FROM location ORDER BY name";
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

                if (e.ColumnIndex == historyDataGridView.Columns["serial_number"].Index)
                {
                    string newSerialNumber = row.Cells["serial_number"].Value.ToString();
                    string updateSerialNumberQuery = $"UPDATE history SET serial_number = '{newSerialNumber}' WHERE id = {historyId}";
                    await new DB_Integrator().QueryAsync(updateSerialNumberQuery, null);
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
                if (isViewer)
                {
                    e.Control.Enabled = false;
                    return;
                }

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
                if (isViewer) return;

                if (e.RowIndex >= 0)
                {
                    bool noteColumnExists = historyDataGridView.Columns.Contains("Note");
                    bool tktNumColumnExists = historyDataGridView.Columns.Contains("Tkt #");
                    bool serialNumberColumnExists = historyDataGridView.Columns.Contains("serial_number");

                    if ((noteColumnExists && e.ColumnIndex == historyDataGridView.Columns["Note"].Index) ||
                        (tktNumColumnExists && e.ColumnIndex == historyDataGridView.Columns["Tkt #"].Index) ||
                        (serialNumberColumnExists && e.ColumnIndex == historyDataGridView.Columns["serial_number"].Index))
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
                RenameColumns(); // Ensure columns are renamed after data is loaded
                historyDataGridView.DataSource = historyTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Print_Click(object sender, EventArgs e)
        {
            if (_isPrintDialogOpen) return; // Prevent multiple print dialogs from opening
            _isPrintDialogOpen = true;

            try
            {
                _selectedStartDate = startDate.Value.Date;
                _selectedEndDate = endDate.Value.Date;

                // Ensure the end date includes the whole day
                _selectedEndDate = _selectedEndDate.AddDays(1).AddTicks(-1);

                string query = $@"
            SELECT id_product, l.name AS location_name, serial_number, date, note, ticket_num
            FROM history h
            JOIN location l ON h.id_location = l.id
            WHERE date BETWEEN '{_selectedStartDate:yyyy-MM-dd HH:mm:ss}' AND '{_selectedEndDate:yyyy-MM-dd HH:mm:ss}'";

                DataTable dataTable = await new DB_Integrator().GetDataTableAsync(query, null);
                if (dataTable.Rows.Count > 0)
                {
                    _historyDataTable = dataTable;
                    _printFullTable = true;
                    PrintSerialNumbers();
                }
                else
                {
                    MessageBox.Show("No serial numbers found for the selected date range.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                Console.WriteLine(ex);
            }
        }

        private void PrintSerialNumbers()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument,
                UseEXDialog = true
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            _isPrintDialogOpen = false; // Reset the flag after the dialog is closed
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            Font font2 = new Font("Arial", 16);
            float lineHeight = font.GetHeight();
            float yPosition = e.MarginBounds.Top;

            string path = Environment.CurrentDirectory;
            path = Path.Combine(path, "Images\\history.png");
            // Load the image for the header
            Image headerImage = Image.FromFile(path); // Change this to the path of your image file

            // Calculate the header height
            float headerHeight = headerImage.Height * 1.0f; // Increase the scaling factor for the image height
            float headerImageWidth = headerImage.Width * 1.0f; // Increase the scaling factor for the image width

            // Draw the image in the header
            graphics.DrawImage(headerImage, e.MarginBounds.Left, yPosition, headerImageWidth, headerHeight);

            // Draw the text next to the image
            string headerText = $"Serial Numbers Inputted on {_selectedStartDate:MMMM dd,yyyy} to {_selectedEndDate:MMMM dd,yyyy}";
            float textXPosition = e.MarginBounds.Left + headerImageWidth + 10; // Add some spacing between the image and text
            graphics.DrawString(headerText, font2, Brushes.Black, textXPosition, yPosition + (headerHeight - font2.GetHeight()) / 2);

            // Adjust yPosition for the next drawing
            yPosition += headerHeight + 20; // Add some spacing after the header

            // Calculate the maximum width required for each column based on the data
            var columnWidths = new Dictionary<string, float>();
            float totalColumnWidth = 0;
            foreach (DataGridViewColumn column in historyDataGridView.Columns)
            {
                if (column.Name == "id" || column.Name == "id_product") continue; // Skip the "ID" and "id_product" columns

                float maxWidth = 0;
                foreach (DataGridViewRow row in historyDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;
                    float cellWidth = graphics.MeasureString(row.Cells[column.Index].Value?.ToString() ?? string.Empty, font).Width;
                    if (cellWidth > maxWidth)
                    {
                        maxWidth = cellWidth;
                    }
                }
                columnWidths[column.Name] = maxWidth + 10; // Add padding
                totalColumnWidth += columnWidths[column.Name];
            }

            // Scale down if the table width exceeds the page width
            float scale = 1.0f;
            if (totalColumnWidth > e.MarginBounds.Width)
            {
                scale = e.MarginBounds.Width / totalColumnWidth;
            }

            // Adjust column widths based on the scale
            foreach (var column in columnWidths.Keys.ToList())
            {
                columnWidths[column] *= scale;
            }

            // Print column headers
            float xPosition = e.MarginBounds.Left;
            foreach (DataGridViewColumn column in historyDataGridView.Columns)
            {
                if (column.Name == "id" || column.Name == "id_product") continue; // Skip the "ID" and "id_product" columns

                float columnWidth = columnWidths[column.Name];
                graphics.DrawRectangle(Pens.Black, xPosition, yPosition, columnWidth, lineHeight);
                graphics.DrawString(column.HeaderText, font, Brushes.Black, xPosition, yPosition);
                xPosition += columnWidth;
            }

            yPosition += lineHeight;

            // Print rows
            foreach (DataGridViewRow row in historyDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                xPosition = e.MarginBounds.Left;
                foreach (DataGridViewColumn column in historyDataGridView.Columns)
                {
                    if (column.Name == "id" || column.Name == "id_product") continue; // Skip the "ID" and "id_product" columns

                    float columnWidth = columnWidths[column.Name];
                    graphics.DrawRectangle(Pens.Black, xPosition, yPosition, columnWidth, lineHeight);
                    graphics.DrawString(row.Cells[column.Index].Value?.ToString() ?? string.Empty, font, Brushes.Black, xPosition, yPosition);
                    xPosition += columnWidth;
                }

                yPosition += lineHeight;

                if (yPosition + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }
    }
}
