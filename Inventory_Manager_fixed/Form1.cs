using System;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class Form1 : Form
    {
        private DB_Integrator _dbIntegrator;

        public Form1()
        {
            InitializeComponent();
            _dbIntegrator = new DB_Integrator();
        }
        public static string insert_data_into_history_if_not_exists = "INSERT INTO history (id_product, id_location, id_action, serial_number, date, note)" +
            " SELECT {0}, {1}, {2}, '{3}','{4}','{5}' " +
            " WHERE NOT EXISTS ( SELECT * FROM history WHERE serial_number = '{3}');"; //this very long and more than likely bad piece of code is what allows me to add product histories

        public static string search_function = @"
            SELECT * FROM product 
            WHERE CAST(id AS TEXT) LIKE '%{0}%' 
            OR model_number LIKE '%{0}%' 
            OR type LIKE '%{0}%' 
            OR barcode LIKE '%{0}%';";

        public static string select_All_From_History = @"
            SELECT * FROM history 
            WHERE id_product = {0} 
            ORDER BY id ASC"; // Product history lookup

        public static string updateQuantity = @"
            UPDATE product
            SET quantity = quantity + {0}
            WHERE id = {1}";
        public static string update_history_note = "UPDATE history SET note = '{0}' WHERE serial_number = '{1}' AND id_product = {2}"; //updates product history

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Subscribe to the CellDoubleClick event
            Product_List.CellDoubleClick += Product_List_CellDoubleClick;
            await LoadDataGridAsync();
        }

        private async Task LoadDataGridAsync(int? selectedProductId = null)
        {
            string query = "SELECT * FROM product"; // Replace with your actual query
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            var sortColumn = Product_List.SortedColumn;
            var sortOrder = Product_List.SortOrder;

            Product_List.DataSource = dataTable;

            if (sortColumn != null)
            {
                ListSortDirection direction = sortOrder == SortOrder.Ascending
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending;
                Product_List.Sort(sortColumn, direction);
            }

            if (selectedProductId.HasValue)
            {
                foreach (DataGridViewRow row in Product_List.Rows)
                {
                    if (Convert.ToInt32(row.Cells["id"].Value) == selectedProductId.Value)
                    {
                        Product_List.ClearSelection();
                        row.Selected = true;
                        Product_List.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                try
                {
                    DataTable dataTable = await _dbIntegrator.GetDataTableAsync(search_function, new string[] { searchTerm });
                    Product_List.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No results found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    Console.WriteLine(ex);
                }
            }
            else
            {
                await LoadDataGridAsync(); // Load all data if search term is empty
            }
        }

        private async void Product_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the double-clicked cell is not the header
            if (e.RowIndex >= 0)
            {
                // Get the 'id' value from the selected row
                int productId = Convert.ToInt32(Product_List.Rows[e.RowIndex].Cells["id"].Value);

                // Query to get the history based on the selected product ID
                string query = string.Format(select_All_From_History, productId);

                try
                {
                    DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

                    // Open the new form and pass the history data
                    History historyForm = new History(dataTable);
                    historyForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    Console.WriteLine(ex);
                }
            }
        }

        private async void increaseQuantityButton_Click(object sender, EventArgs e)
        {
            await UpdateProductQuantityAsync(1);
        }

        private async void decreaseQuantityButton_Click(object sender, EventArgs e)
        {
            await UpdateProductQuantityAsync(-1);
        }

        private async Task UpdateProductQuantityAsync(int quantityChange)
        {
            if (Product_List.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["id"].Value);
                string requireSerialNumberQuery = "SELECT require_serial_number FROM product WHERE id = " + productId;
                object result = await _dbIntegrator.Select(requireSerialNumberQuery, null);
                bool requireSerialNumber = Convert.ToBoolean(result);

                if (quantityChange > 0 && requireSerialNumber)
                {
                    List<string> serialNumbers = PromptForSerialNumbers(quantityChange);
                    if (serialNumbers.Count != quantityChange)
                    {
                        // User canceled the serial number input
                        return;
                    }
                    foreach (string serialNumber in serialNumbers)
                    {
                        string insertHistory = string.Format(insert_data_into_history_if_not_exists, productId, 1, 1, serialNumber, DateTime.Now.ToString("yyyy-MM-dd"), "null");
                        await _dbIntegrator.Query(insertHistory, null);
                    }
                }
                else if (quantityChange < 0)
                {
                    // Get the serial numbers associated with this product
                    string serialQuery = "SELECT serial_number FROM history WHERE id_product = " + productId;
                    DataTable serialNumbersTable = await _dbIntegrator.GetDataTableAsync(serialQuery, null);
                    List<string> serialNumbers = serialNumbersTable.AsEnumerable().Select(row => row.Field<string>("serial_number")).ToList();

                    using (var form = new LocationAndNoteForm(await GetLocationsAsync(), serialNumbers))
                    {
                        if (form.ShowDialog() != DialogResult.OK)
                        {
                            // User canceled the location and note input
                            return;
                        }

                        int locationId = form.SelectedLocationId;
                        string note = form.Note;
                        string selectedSerialNumber = form.SelectedSerialNumber;

                        string updateHistoryNote = string.Format(update_history_note, note, selectedSerialNumber, productId);
                        await _dbIntegrator.Query(updateHistoryNote, null);
                    }
                }

                // Apply quantity change to the product
                string query = string.Format(updateQuantity, quantityChange, productId);
                await _dbIntegrator.Query(query, null);

                await LoadDataGridAsync(productId); // Refresh the DataGridView and reselect the row
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }


        private async Task<List<Tuple<int, string>>> GetLocationsAsync()
        {
            string query = "SELECT id, name FROM location"; // Replace with your actual query
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);
            return dataTable.AsEnumerable().Select(row => new Tuple<int, string>(row.Field<int>("id"), row.Field<string>("name"))).ToList();
        }





        private async void addButton_Click(object sender, EventArgs e)
        {
            string modelNumber = modelNumberTextBox.Text.Trim();
            string type = typeTextBox.Text.Trim();
            int quantity;
            string barcode = barcodeTextBox.Text.Trim();
            bool requireSerialNumber = requireSerialNumberCheckBox.Checked;
            string product_add = "INSERT INTO product(model_number,type,quantity,barcode,require_serial_number) VALUES('{0}','{1}',{2},'{3}',{4}) RETURNING id;"; // adds a product

            if (string.IsNullOrEmpty(modelNumber) || string.IsNullOrEmpty(type) || !int.TryParse(quantityTextBox.Text.Trim(), out quantity) || string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Please fill in all product details.");
                return;
            }

            try
            {
                string query = string.Format(product_add, modelNumber, type, quantity, barcode, requireSerialNumber);
                object result = await _dbIntegrator.Select(query, null);
                int newProductId = Convert.ToInt32(result);

                if (requireSerialNumber)
                {
                    List<string> serialNumbers = PromptForSerialNumbers(quantity);
                    if (serialNumbers.Count != quantity)
                    {
                        // User canceled the serial number input, delete the newly created product
                        string deleteProductQuery = $"DELETE FROM product WHERE id = {newProductId}";
                        await _dbIntegrator.Query(deleteProductQuery, null);
                        return;
                    }
                    foreach (string serialNumber in serialNumbers)
                    {
                        string insertHistory = string.Format(insert_data_into_history_if_not_exists, newProductId, 1, 1, serialNumber, DateTime.Now.ToString("yyyy-MM-dd"), "null");
                        await _dbIntegrator.Query(insertHistory, null);
                    }
                }

                await LoadDataGridAsync(); // Refresh the DataGridView
                MessageBox.Show("Product added successfully.");
                ClearProductFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                Console.WriteLine(ex);
            }
        }



        private void ClearProductFormFields()
        {
            modelNumberTextBox.Clear();
            typeTextBox.Clear();
            quantityTextBox.Clear();
            barcodeTextBox.Clear();
            requireSerialNumberCheckBox.Checked = false;
        }

        private List<string> PromptForSerialNumbers(int count)
        {
            List<string> serialNumbers = new List<string>();
            for (int i = 0; i < count; i++)
            {
                using (var inputForm = new SerialNumberInputForm(i + 1, count))
                {
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        if (!string.IsNullOrEmpty(inputForm.SerialNumber))
                        {
                            serialNumbers.Add(inputForm.SerialNumber);
                        }
                        else
                        {
                            MessageBox.Show("Serial number cannot be empty. Please enter a valid serial number.");
                            i--;
                        }
                    }
                    else
                    {
                        return new List<string>(); // Return empty list to indicate cancellation
                    }
                }
            }
            return serialNumbers;
        }




    }
}

