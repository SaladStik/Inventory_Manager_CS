using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class QuickSheetCreation : Form
    {
        private DB_Integrator _dbIntegrator;
        private List<Product> _products;
        private List<Product> _selectedProducts;

        public QuickSheetCreation(DB_Integrator dbIntegrator)
        {
            InitializeComponent();
            _dbIntegrator = dbIntegrator;
            _selectedProducts = new List<Product>();
        }

        private async void QuickSheetCreation_Load(object sender, EventArgs e)
        {
            await LoadProducts();
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

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || !_selectedProducts.Any())
            {
                MessageBox.Show("Please provide a name, description, and add at least one product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string insertQuery = $"INSERT INTO quick_sheets (name, description) VALUES ('{name}', '{description}') RETURNING id";
                int quickSheetId = Convert.ToInt32(await _dbIntegrator.SelectAsync(insertQuery, null));

                foreach (var product in _selectedProducts)
                {
                    string insertProductQuery = $"INSERT INTO quick_sheet_products (quick_sheet_id, product_id) VALUES ({quickSheetId}, {product.Id})";
                    await _dbIntegrator.QueryAsync(insertProductQuery, null);
                }

                MessageBox.Show("QuickSheet created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Bin { get; set; }
        public string DisplayName => $"{Alias} - {Bin}";
    }
}
