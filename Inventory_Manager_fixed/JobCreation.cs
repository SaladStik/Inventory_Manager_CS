using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class JobCreation : Form
    {
        private DB_Integrator _dbIntegrator;
        private List<DBProduct> _products;
        private List<JobProduct> _jobProducts;

        public JobCreation(DB_Integrator dbIntegrator)
        {
            InitializeComponent();
            _dbIntegrator = dbIntegrator;
            _jobProducts = new List<JobProduct>();
        }

        private async void JobCreation_Load(object sender, EventArgs e)
        {
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            string query = "SELECT id, alias, bin, quantity FROM product";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            _products = new List<DBProduct>();

            foreach (DataRow row in dataTable.Rows)
            {
                _products.Add(new DBProduct
                {
                    Id = Convert.ToInt32(row["id"]),
                    Alias = row["alias"].ToString(),
                    Bin = row["bin"].ToString(),
                    Quantity = Convert.ToInt32(row["quantity"])
                });
            }

            UpdateProductComboBox("");
        }

        private void UpdateProductComboBox(string filter)
        {
            var filteredProducts = _products.Where(p => p.Alias.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 || p.Id.ToString().IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            JobProductComboBox.DataSource = filteredProducts;
            JobProductComboBox.DisplayMember = "DisplayName";
            JobProductComboBox.ValueMember = "Id";
        }

        private void JobProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProductComboBox(JobProductSearchTextBox.Text);
        }

        private void JobAddProductButton_Click(object sender, EventArgs e)
        {
            DBProduct selectedProduct = (DBProduct)JobProductComboBox.SelectedItem;
            int quantity;
            if (selectedProduct != null && !_jobProducts.Any(p => p.Product.Id == selectedProduct.Id) && int.TryParse(JobProductQuantityTextBox.Text, out quantity) && quantity > 0)
            {
                if (quantity > selectedProduct.Quantity)
                {
                    MessageBox.Show($"Cannot add quantity greater than stock. Available stock: {selectedProduct.Quantity}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _jobProducts.Add(new JobProduct
                {
                    Product = selectedProduct,
                    Quantity = quantity,
                    OriginalQuantity = selectedProduct.Quantity
                });
                RefreshProductDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a valid product and enter a valid quantity.");
            }
        }

        private void RefreshProductDataGridView()
        {
            JobProductDataGridView.DataSource = null;
            JobProductDataGridView.DataSource = _jobProducts.Select(p => new
            {
                p.Product.Alias,
                p.Product.Bin,
                p.Quantity
            }).ToList();
        }

        private async void JobSaveButton_Click(object sender, EventArgs e)
        {
            string jobName = JobNameTextBox.Text.Trim();
            string jobDescription = JobDescriptionTextBox.Text.Trim();
            string tktNum = TktNumText.Text.Trim();

            if (string.IsNullOrEmpty(jobName) || string.IsNullOrEmpty(jobDescription) || !_jobProducts.Any())
            {
                MessageBox.Show("Please provide a job name, description, and add at least one product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string insertQuery = $"INSERT INTO jobs (name, description, tkt_num, users_id, date) VALUES ('{jobName}', '{jobDescription}', '{tktNum}', '{UserSession.UserId}', '{DateTime.Now}') RETURNING id";
                int jobId = Convert.ToInt32(await _dbIntegrator.SelectAsync(insertQuery, null));

                foreach (var jobProduct in _jobProducts)
                {
                    string insertProductQuery = $"INSERT INTO jobs_products (job_id, product_id, product_quantity, product_original_quantity) VALUES ({jobId}, {jobProduct.Product.Id}, {jobProduct.Quantity}, {jobProduct.Quantity})";
                    await _dbIntegrator.QueryAsync(insertProductQuery, null);

                    // Update the stock quantity of the product
                    string updateStockQuery = $"UPDATE product SET quantity = quantity - {jobProduct.Quantity} WHERE id = {jobProduct.Product.Id}";
                    await _dbIntegrator.QueryAsync(updateStockQuery, null);

                    // Log the stock update
                    string logQuery = $@"
                        INSERT INTO the_log (event_id, users_id, product_id, date, previous_value, new_value, field_updated, serial_number)
                        VALUES ('E004', {UserSession.UserId}, {jobProduct.Product.Id}, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', '{jobProduct.OriginalQuantity}', '{jobProduct.OriginalQuantity - jobProduct.Quantity}', 'quantity', '{jobProduct.Product.Id}')";
                    await _dbIntegrator.QueryAsync(logQuery, null);
                }

                MessageBox.Show("Job created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class JobProduct
    {
        public DBProduct Product { get; set; }
        public int Quantity { get; set; }
        public int OriginalQuantity { get; set; }
    }

    public class DBProduct
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Bin { get; set; }
        public int Quantity { get; set; }
        public string DisplayName => $"{Alias} - {Bin} (Stock: {Quantity})";
    }
}
