using Inventory.DB_Interaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class Form1 : Form
    {
        private DB_Integrator _dbIntegrator;
        private System.Windows.Forms.Timer _refreshTimer;

        public Form1()
        {
            InitializeComponent();
            _dbIntegrator = new DB_Integrator();

            // Initialize the timer
            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 10000; // 10 seconds
            _refreshTimer.Tick += RefreshTimer_Tick;
            _refreshTimer.Start();
        }

        public static string associate_product_supplier = "UPDATE product SET supplier_id = {0} WHERE id = {1};";
        public static string update_minimum_stock = "UPDATE product SET min_stock = {0} WHERE id = {1};";

        public static string select_Product = "SELECT p.id, p.model_number, p.alias, p.type, p.quantity, p.barcode, p.require_serial_number, p.image_url, s.name AS supplier, p.supplier_link, p.min_stock FROM product p LEFT JOIN supplier s ON p.supplier_id = s.id ORDER BY p.id ASC";

        public static string product_add = @"
            INSERT INTO product (
                model_number, alias, type, quantity, barcode, require_serial_number, supplier_id, supplier_link, min_stock
            ) VALUES (
                '{0}', '{1}', '{2}', {3}, '{4}', {5}, {6}, '{7}', {8}
            ) RETURNING id;";

        public static string product_update = "UPDATE product SET quantity = {0} WHERE barcode = '{1}'";
        public static string select_Location = "SELECT id FROM location WHERE name = '{0}';";
        public static string update_history_location = "UPDATE history SET id_location = '{0}' WHERE serial_number = '{1}' AND id_product = {2}";
        public static string insert_data_into_history_if_not_exists = @"
            INSERT INTO history (id_product, id_location, serial_number, date, note)
            SELECT {0}, {1}, '{2}', '{3}', '{4}'
            WHERE NOT EXISTS (SELECT * FROM history WHERE serial_number = '{2}')";
        public static string search_function = @"
            SELECT p.id, p.model_number, p.alias, p.type, p.quantity, p.barcode, p.require_serial_number, p.image_url, s.name AS supplier, p.supplier_link, p.min_stock 
            FROM product p
            LEFT JOIN supplier s ON p.supplier_id = s.id
            WHERE CAST(p.id AS TEXT) ILIKE '%{0}%' 
            OR p.model_number ILIKE '%{0}%' 
            OR p.type ILIKE '%{0}%' 
            OR p.barcode ILIKE '%{0}%' 
            OR p.alias ILIKE '%{0}%';";
        public static string select_All_From_History = @"
             SELECT h.id, h.id_product, l.name AS location_name, h.serial_number, h.date, h.note, h.ticket_num
             FROM history h
             JOIN location l ON h.id_location = l.id
             WHERE h.id_product = {0}
             ORDER BY h.id ASC";
        public static string updateQuantity = @"
            UPDATE product
            SET quantity = quantity + {0}
            WHERE id = {1}";
        public static string update_history_note = "UPDATE history SET note = '{0}', id_location = {3} WHERE serial_number = '{1}' AND id_product = {2}";
        public static string insert_location = "INSERT INTO location(name) VALUES('{0}')";
        public static string insert_supplier = "INSERT INTO supplier(name) VALUES('{0}') RETURNING id;";
        public static string select_Supplier = "SELECT id, name FROM supplier ORDER BY name ASC;";
        public static string update_supplier_link = "UPDATE product SET supplier_link = '{0}' WHERE id = {1};";

        private async void Form1_Load(object sender, EventArgs e)
        {
            Product_List.CellDoubleClick += Product_List_CellDoubleClick;
            Product_List.DataBindingComplete += Product_List_DataBindingComplete;
            ImageUploadButton.Click += ImageUploadButton_Click;
            SupplierAddButton.Click += SupplierAddButton_Click; // Add Supplier Button Click
            SupplierLinkButton.Click += SupplierLinkButton_Click; // Supplier Link Button Click
            AddMinimumStock.Click += AddMinimumStock_Click; // Add Minimum Stock Button Click
            MinimumStockTextBox.KeyPress += MinimumStockTextBox_KeyPress; // Restrict to integers
            MinimumStockTextBox.TextChanged += MinimumStockTextBox_TextChanged; // Handle text changes
            SettingsButton.Click += SettingsButton_Click; // Add Settings Button Click handler
            await LoadDataGridAsync();
            await LoadTypesAsync(); // Load types into ComboBox
            await LoadSuppliersAsync(); // Load suppliers into ComboBox
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
        }

        private void MinimumStockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys such as backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void MinimumStockTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MinimumStockTextBox.Text, out int result))
            {
                // Valid integer
            }
            else
            {
                // Handle invalid integer input if needed
            }
        }

        private async void AddMinimumStock_Click(object sender, EventArgs e)
        {
            if (Product_List.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["id"].Value);

                if (!int.TryParse(MinimumStockTextBox.Text.Trim(), out int minStockValue) || minStockValue < 0)
                {
                    MessageBox.Show("Please enter a valid minimum stock value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string query = string.Format(update_minimum_stock, minStockValue, productId);
                    await _dbIntegrator.QueryAsync(query, null);
                    MessageBox.Show("Minimum stock value updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataGridAsync(productId); // Refresh the DataGridView and reselect the row
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private async void RefreshTimer_Tick(object sender, EventArgs e)
        {
            await PerformDBSweepAsync();
            await RefreshProductDataGridAsync();
        }

        private async Task RefreshProductDataGridAsync()
        {
            string searchTerm = searchTextBox.Text.Trim();
            int? selectedProductId = null;
            int? selectedRowIndex = null;

            if (Product_List.SelectedRows.Count > 0)
            {
                var selectedRow = Product_List.SelectedRows[0];
                if (selectedRow.Cells["id"].Value != DBNull.Value)
                {
                    selectedProductId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    selectedRowIndex = selectedRow.Index;
                }
            }

            await LoadDataGridAsync(selectedProductId);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string searchQuery = string.Format(search_function, searchTerm.ToLower());
                DataTable dataTable = await _dbIntegrator.GetDataTableAsync(searchQuery, null);
                Product_List.DataSource = dataTable;
            }

            if (selectedRowIndex.HasValue && selectedRowIndex < Product_List.Rows.Count)
            {
                Product_List.Rows[selectedRowIndex.Value].Selected = true;
                Product_List.FirstDisplayedScrollingRowIndex = selectedRowIndex.Value;
            }
        }

        private async Task LoadDataGridAsync(int? selectedProductId = null)
        {
            string query = select_Product;
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            var sortColumn = Product_List.SortedColumn;
            var sortOrder = Product_List.SortOrder;

            Product_List.DataSource = dataTable;

            if (sortColumn != null && Product_List.Columns.Contains(sortColumn.Name))
            {
                ListSortDirection direction = sortOrder == SortOrder.Ascending
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending;
                Product_List.Sort(Product_List.Columns[sortColumn.Name], direction);
            }

            if (selectedProductId.HasValue)
            {
                foreach (DataGridViewRow row in Product_List.Rows)
                {
                    if (row.Cells["id"].Value != DBNull.Value && Convert.ToInt32(row.Cells["id"].Value) == selectedProductId.Value)
                    {
                        Product_List.ClearSelection();
                        row.Selected = true;
                        Product_List.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void Product_List_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Iterate through the rows and change colors based on stock levels
            foreach (DataGridViewRow row in Product_List.Rows)
            {
                if (row.Cells["quantity"].Value != DBNull.Value && row.Cells["min_stock"].Value != DBNull.Value)
                {
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    int minStock = Convert.ToInt32(row.Cells["min_stock"].Value);

                    if (quantity <= 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (quantity < minStock)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private async Task LoadTypesAsync()
        {
            string query = "SELECT DISTINCT type FROM product";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);
            typeComboBox.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                typeComboBox.Items.Add(row["type"].ToString());
            }
        }

        private async Task LoadSuppliersAsync()
        {
            string query = select_Supplier;
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);
            supplierSelectionBox.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                supplierSelectionBox.Items.Add(row["name"].ToString());
            }
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                try
                {
                    DataTable dataTable = await _dbIntegrator.GetDataTableAsync(string.Format(search_function, searchTerm.ToLower()), null);
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
            try
            {
                if (e.RowIndex >= 0)
                {
                    int productId = Convert.ToInt32(Product_List.Rows[e.RowIndex].Cells["id"].Value);

                    // Check if the double-clicked cell is the image URL column
                    if (Product_List.Columns[e.ColumnIndex].Name == "image_url")
                    {
                        string imageUrl = Product_List.Rows[e.RowIndex].Cells["image_url"].Value.ToString();
                        if (!string.IsNullOrEmpty(imageUrl))
                        {
                            string imagePath = Path.Combine(ConfigurationManager.AppSettings["ImageServerPath"], imageUrl);
                            if (File.Exists(imagePath))
                            {
                                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                                {
                                    FileName = imagePath,
                                    UseShellExecute = true,
                                    Verb = "open"
                                });
                            }
                            else
                            {
                                MessageBox.Show("Image file not found.");
                            }
                        }
                    }
                    // Check if the double-clicked cell is the supplier link column
                    else if (Product_List.Columns[e.ColumnIndex].Name == "supplier_link")
                    {
                        string supplierLink = Product_List.Rows[e.RowIndex].Cells["supplier_link"].Value.ToString();
                        if (!string.IsNullOrEmpty(supplierLink))
                        {
                            try
                            {
                                // Ensure the link is opened in the default web browser
                                var psi = new System.Diagnostics.ProcessStartInfo
                                {
                                    FileName = supplierLink,
                                    UseShellExecute = true
                                };

                                // Check if the link starts with HTTP or HTTPS to ensure it is a URL
                                if (supplierLink.StartsWith("http://") || supplierLink.StartsWith("https://") || supplierLink.StartsWith("www."))
                                {
                                    System.Diagnostics.Process.Start(psi);
                                }
                                else
                                {
                                    MessageBox.Show("Invalid URL. Please ensure the supplier link starts with http://, https://, or www.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred: {ex.Message}");
                                Console.WriteLine(ex);
                            }
                        }
                    }
                    else
                    {
                        bool requireSerialNumber = Convert.ToBoolean(Product_List.Rows[e.RowIndex].Cells["require_serial_number"].Value);

                        if (!requireSerialNumber)
                        {
                            return;
                        }

                        string query = string.Format(select_All_From_History, productId);

                        try
                        {
                            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);
                            Inventory_Manager.History historyForm = new Inventory_Manager.History(productId, dataTable);
                            historyForm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                            Console.WriteLine(ex);
                        }
                    }
                }
            }
            catch { }
        }


        private async void increaseQuantityButton_Click(object sender, EventArgs e)
        {
            await UpdateProductQuantityAsync(true);
        }

        private async void decreaseQuantityButton_Click(object sender, EventArgs e)
        {
            if (Product_List.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["id"].Value);
                string requireSerialNumberQuery = "SELECT require_serial_number FROM product WHERE id = " + productId;
                object result = await _dbIntegrator.SelectAsync(requireSerialNumberQuery, null);
                bool requireSerialNumber = Convert.ToBoolean(result);

                if (requireSerialNumber)
                {
                    MessageBox.Show("Quantity cannot be decreased for products that track serial numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    await UpdateProductQuantityAsync(false);
                }
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private async Task UpdateProductQuantityAsync(bool isIncrease)
        {
            if (Product_List.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["id"].Value);
                if (!int.TryParse(QuantityChangeAmtBox.Text.Trim(), out int quantityChange) || quantityChange <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                if (!isIncrease)
                {
                    quantityChange = -quantityChange;
                }

                string requireSerialNumberQuery = "SELECT require_serial_number FROM product WHERE id = " + productId;
                object result = await _dbIntegrator.SelectAsync(requireSerialNumberQuery, null);
                bool requireSerialNumber = Convert.ToBoolean(result);

                if (quantityChange > 0 && requireSerialNumber)
                {
                    List<string> serialNumbers = await PromptForSerialNumbers(quantityChange);
                    if (serialNumbers.Count != quantityChange)
                    {
                        return;
                    }
                    foreach (string serialNumber in serialNumbers)
                    {
                        string insertHistory = string.Format(insert_data_into_history_if_not_exists, productId, 1, serialNumber, DateTime.Now.ToString("yyyy-MM-dd"), ""); //default serial number add in creation
                        await _dbIntegrator.QueryAsync(insertHistory, null);
                    }
                }

                string query = string.Format(updateQuantity, quantityChange, productId);
                await _dbIntegrator.QueryAsync(query, null);

                await LoadDataGridAsync(productId); // Refresh the DataGridView and reselect the row
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private async void addLocationButton_Click(object sender, EventArgs e)
        {
            string locationName = locationNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(locationName))
            {
                MessageBox.Show("Please enter a location name.");
                return;
            }

            string query = string.Format(insert_location, locationName);

            try
            {
                await _dbIntegrator.QueryAsync(query, null);
                MessageBox.Show("Location added successfully.");
                locationNameTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                Console.WriteLine(ex);
            }
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            string modelNumber = modelNumberTextBox.Text.Trim();
            string alias = productAlias.Text.Trim();
            string type = typeComboBox.Text.Trim(); // Use ComboBox for type
            int quantity;
            string barcode = barcodeTextBox.Text.Trim();
            bool requireSerialNumber = requireSerialNumberCheckBox.Checked;
            string supplier = supplierSelectionBox.Text.Trim();
            string supplierLink = supplierLinkBox.Text.Trim();
            int? minStock = null;

            if (string.IsNullOrEmpty(modelNumber) || string.IsNullOrEmpty(type) || !int.TryParse(quantityTextBox.Text.Trim(), out quantity) || string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Please fill in all product details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(MinimumStockTextBox.Text.Trim(), out int minStockValue))
            {
                minStock = minStockValue;
            }

            try
            {
                int? supplierId = null;
                if (!string.IsNullOrEmpty(supplier))
                {
                    // Check if the supplier exists
                    string checkSupplierQuery = $"SELECT id FROM supplier WHERE name = '{supplier}'";
                    object result = await _dbIntegrator.SelectAsync(checkSupplierQuery, null);

                    if (result != null)
                    {
                        supplierId = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Insert new supplier if it doesn't exist
                        string insertSupplierQuery = string.Format(insert_supplier, supplier);
                        result = await _dbIntegrator.SelectAsync(insertSupplierQuery, null);
                        supplierId = Convert.ToInt32(result);
                    }
                }

                string supplierIdValueString = supplierId.HasValue ? supplierId.Value.ToString() : "NULL";
                string minStockValueString = minStock.HasValue ? minStock.Value.ToString() : "NULL";

                string productAdd = string.Format(product_add, modelNumber, alias, type, quantity, barcode, requireSerialNumber, supplierIdValueString, supplierLink, minStockValueString);
                object newProductIdObj = await _dbIntegrator.SelectAsync(productAdd, null);
                int newProductId = Convert.ToInt32(newProductIdObj);

                if (requireSerialNumber)
                {
                    List<string> serialNumbers = await PromptForSerialNumbers(quantity);
                    if (serialNumbers.Count != quantity)
                    {
                        string deleteProductQuery = $"DELETE FROM product WHERE id = {newProductId}";
                        await _dbIntegrator.QueryAsync(deleteProductQuery, null);
                        return;
                    }
                    foreach (string serialNumber in serialNumbers)
                    {
                        string insertHistory = string.Format(insert_data_into_history_if_not_exists, newProductId, 1, serialNumber, DateTime.Now.ToString("yyyy-MM-dd"), "");//default prudct creation 
                        await _dbIntegrator.QueryAsync(insertHistory, null);
                    }
                }

                await LoadDataGridAsync(); // Refresh the DataGridView
                await LoadTypesAsync(); // Reload the types in ComboBox
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearProductFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }

        private async void SupplierAddButton_Click(object sender, EventArgs e)
        {
            string supplierName = supplierSelectionBox.Text.Trim();

            if (string.IsNullOrEmpty(supplierName))
            {
                MessageBox.Show("Please enter a supplier name.");
                return;
            }

            try
            {
                // Check if the supplier already exists
                string checkSupplierQuery = $"SELECT id FROM supplier WHERE name = '{supplierName}'";
                object result = await _dbIntegrator.SelectAsync(checkSupplierQuery, null);

                int supplierId;
                if (result != null)
                {
                    supplierId = Convert.ToInt32(result);
                }
                else
                {
                    // Insert new supplier if it doesn't exist
                    string insertSupplierQuery = string.Format(insert_supplier, supplierName);
                    result = await _dbIntegrator.SelectAsync(insertSupplierQuery, null);
                    supplierId = Convert.ToInt32(result);
                }

                // Associate supplier with selected product
                if (Product_List.SelectedRows.Count > 0)
                {
                    int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["id"].Value);
                    string associateQuery = string.Format(associate_product_supplier, supplierId, productId);
                    await _dbIntegrator.QueryAsync(associateQuery, null);
                    MessageBox.Show("Supplier associated with the selected product successfully.");
                    await LoadDataGridAsync(productId); // Refresh the DataGridView and reselect the row
                }
                else
                {
                    MessageBox.Show("Supplier added successfully.");
                }

                // Refresh the supplier selection box
                await LoadSuppliersAsync();
                supplierSelectionBox.Text = supplierName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                Console.WriteLine(ex);
            }
        }

        private async void SupplierLinkButton_Click(object sender, EventArgs e)
        {
            if (Product_List.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["id"].Value);
                string supplierLink = supplierLinkBox.Text.Trim();

                if (string.IsNullOrEmpty(supplierLink) ||
                    !(supplierLink.StartsWith("http://") || supplierLink.StartsWith("https://") || supplierLink.StartsWith("www.")))
                {
                    MessageBox.Show("Please enter a valid supplier link that starts with http://, https://, or www.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = string.Format(update_supplier_link, supplierLink, productId);
                await _dbIntegrator.QueryAsync(query, null);
                MessageBox.Show("Supplier link updated successfully.");
                await LoadDataGridAsync(productId); // Refresh the DataGridView and reselect the row
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }


        private async Task<List<Tuple<int, string>>> GetLocationsAsync()
        {
            string query = "SELECT id, name FROM location";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);
            return dataTable.AsEnumerable().Select(row => new Tuple<int, string>(row.Field<int>("id"), row.Field<string>("name"))).ToList();
        }

        private async Task<List<string>> PromptForSerialNumbers(int count)
        {
            List<string> serialNumbers = new List<string>();
            for (int i = 0; i < count; i++)
            {
                using (var inputForm = new SerialNumberInputForm(i + 1, count))
                {
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        if (!string.IsNullOrEmpty(inputForm.EnteredSerialNumber))
                        {
                            // Check against the list of already entered serial numbers
                            if (serialNumbers.Contains(inputForm.EnteredSerialNumber))
                            {
                                MessageBox.Show("Serial number already entered in this session. Please enter a different serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                i--;
                                continue;
                            }

                            // Check against the database
                            string query = $"SELECT COUNT(*) FROM history WHERE serial_number = '{inputForm.EnteredSerialNumber}'";
                            object result = await _dbIntegrator.SelectAsync(query, null);
                            int countExisting = Convert.ToInt32(result);

                            if (countExisting > 0)
                            {
                                MessageBox.Show("Serial number already exists in the database. Please enter a different serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                i--;
                            }
                            else
                            {
                                serialNumbers.Add(inputForm.EnteredSerialNumber);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Serial number cannot be empty. Please enter a valid serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            i--;
                        }
                    }
                    else
                    {
                        return new List<string>();
                    }
                }
            }
            return serialNumbers;
        }

        private void ClearProductFormFields()
        {
            modelNumberTextBox.Clear();
            productAlias.Clear();
            typeComboBox.SelectedIndex = -1;
            quantityTextBox.Clear();
            barcodeTextBox.Clear();
            requireSerialNumberCheckBox.Checked = false;
            supplierSelectionBox.SelectedIndex = -1;
            supplierLinkBox.Clear();
            MinimumStockTextBox.Clear();
        }

        private async void DBSweepButton_Click(object sender, EventArgs e)
        {
            await PerformDBSweepAsync();
        }

        private async Task PerformDBSweepAsync()
        {
            try
            {
                // Query to get all products that require serial numbers
                string query = "SELECT id FROM product WHERE require_serial_number = true";
                DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

                foreach (DataRow row in dataTable.Rows)
                {
                    int productId = Convert.ToInt32(row["id"]);

                    // Query to count the number of serial numbers for this product in the stock location (id_location = 1)
                    string countQuery = $"SELECT COUNT(*) FROM history WHERE id_product = {productId} AND id_location = 1";
                    object result = await _dbIntegrator.SelectAsync(countQuery, null);

                    // Check if the result is valid
                    if (result != null && int.TryParse(result.ToString(), out int serialNumberCount))
                    {
                        // Update the product quantity to match the count of serial numbers in stock
                        string updateQuery = $"UPDATE product SET quantity = {serialNumberCount} WHERE id = {productId}";
                        await _dbIntegrator.QueryAsync(updateQuery, null);
                    }
                    else
                    {
                        MessageBox.Show($"Count query result for product ID {productId} is invalid or null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //MessageBox.Show("DB Sweep completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during DB Sweep: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"An error occurred during DB Sweep: {ex}");
            }
        }


        private async void ImageUploadButton_Click(object sender, EventArgs e)
        {
            if (Product_List.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["id"].Value);

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string imageServerPath = ConfigurationManager.AppSettings["ImageServerPath"];
                            string imageName = $"{productId}{Path.GetExtension(openFileDialog.FileName)}";
                            string destPath = Path.Combine(imageServerPath, imageName);

                            File.Copy(openFileDialog.FileName, destPath, true);

                            string updateImageUrlQuery = $"UPDATE product SET image_url = '{imageName}' WHERE id = {productId}";
                            await _dbIntegrator.QueryAsync(updateImageUrlQuery, null);

                            await LoadDataGridAsync(productId);
                            MessageBox.Show("Image uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine(ex);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to upload an image.");
            }
        }

        private void SettingsButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
