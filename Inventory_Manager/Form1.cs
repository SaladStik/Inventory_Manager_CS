using System;
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

            // Ensure the DataGridView is initialized before subscribing to the event
            this.Load += new System.EventHandler(this.Form1_Load);
        }

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

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Subscribe to the CellDoubleClick event
            Product_List.CellDoubleClick += Product_List_CellDoubleClick;
            await LoadDataGridAsync();
        }

        private async Task LoadDataGridAsync()
        {
            string query = "SELECT * FROM product"; // Replace with your actual query
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);
            Product_List.DataSource = dataTable;
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
    }
}