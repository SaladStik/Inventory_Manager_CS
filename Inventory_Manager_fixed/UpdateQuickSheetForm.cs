using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class UpdateQuickSheetForm : Form
    {
        private DB_Integrator _dbIntegrator;
        private List<Product> _products;
        private List<Product> _selectedProducts;

        public UpdateQuickSheetForm(DB_Integrator dbIntegrator)
        {
            InitializeComponent();
            _dbIntegrator = dbIntegrator;
            _selectedProducts = new List<Product>();
        }

        private async void UpdateQuickSheetForm_Load(object sender, EventArgs e)
        {
            await LoadQuickSheets();
            await LoadProducts();
        }

        private async Task LoadQuickSheets()
        {
            string query = "SELECT id, name FROM quick_sheets";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            quickSheetComboBox.DisplayMember = "name";
            quickSheetComboBox.ValueMember = "id";
            quickSheetComboBox.DataSource = dataTable;
        }

        private async Task LoadProducts()
        {
            string query = "SELECT id, alias, bin FROM product";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            _products = new List<Product>();

            foreach (DataRow row in dataTable.Rows)
            {
                _products.Add(new Product
                {
                    Id = Convert.ToInt32(row["id"]),
                    Alias = row["alias"].ToString(),
                    Bin = row["bin"].ToString()
                });
            }

            UpdateProductComboBox("");
        }

        private async Task LoadQuickSheetDetails(int quickSheetId)
        {
            string query = $"SELECT name, description FROM quick_sheets WHERE id = {quickSheetId}";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                nameTextBox.Text = row["name"].ToString();
                descriptionTextBox.Text = row["description"].ToString();
            }

            await LoadQuickSheetProducts(quickSheetId);
        }

        private async Task LoadQuickSheetProducts(int quickSheetId)
        {
            string query = $"SELECT p.id, p.alias, p.bin FROM quick_sheet_products qsp JOIN product p ON qsp.product_id = p.id WHERE qsp.quick_sheet_id = {quickSheetId}";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            _selectedProducts = new List<Product>();

            foreach (DataRow row in dataTable.Rows)
            {
                _selectedProducts.Add(new Product
                {
                    Id = Convert.ToInt32(row["id"]),
                    Alias = row["alias"].ToString(),
                    Bin = row["bin"].ToString()
                });
            }

            RefreshProductDataGridView();
        }

        private void UpdateProductComboBox(string filter)
        {
            var filteredProducts = _products.Where(p => p.Alias.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            productComboBox.DataSource = filteredProducts;
            productComboBox.DisplayMember = "DisplayName";
            productComboBox.ValueMember = "Id";
        }

        private void ProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProductComboBox(productSearchTextBox.Text);
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)productComboBox.SelectedItem;
            if (selectedProduct != null && !_selectedProducts.Any(p => p.Id == selectedProduct.Id))
            {
                _selectedProducts.Add(selectedProduct);
                RefreshProductDataGridView();
            }
        }

        private void RefreshProductDataGridView()
        {
            productDataGridView.DataSource = null;
            productDataGridView.DataSource = _selectedProducts.Select(p => new { p.Alias, p.Bin }).ToList();
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = productDataGridView.SelectedRows[0].Index;
                _selectedProducts.RemoveAt(selectedIndex);
                RefreshProductDataGridView();
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (quickSheetComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a QuickSheet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quickSheetId = (int)quickSheetComboBox.SelectedValue;
            string name = nameTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || !_selectedProducts.Any())
            {
                MessageBox.Show("Please provide a name, description, and add at least one product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string updateQuery = $"UPDATE quick_sheets SET name = '{name}', description = '{description}' WHERE id = {quickSheetId}";
                await _dbIntegrator.QueryAsync(updateQuery, null);

                string deleteQuery = $"DELETE FROM quick_sheet_products WHERE quick_sheet_id = {quickSheetId}";
                await _dbIntegrator.QueryAsync(deleteQuery, null);

                foreach (var product in _selectedProducts)
                {
                    string insertProductQuery = $"INSERT INTO quick_sheet_products (quick_sheet_id, product_id) VALUES ({quickSheetId}, {product.Id})";
                    await _dbIntegrator.QueryAsync(insertProductQuery, null);
                }

                MessageBox.Show("QuickSheet updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void QuickSheetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quickSheetComboBox.SelectedValue != null)
            {
                int quickSheetId = (int)quickSheetComboBox.SelectedValue;
                await LoadQuickSheetDetails(quickSheetId);
            }
        }
    }
}
