using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class DeleteQuickSheetForm : Form
    {
        private DB_Integrator _dbIntegrator;
        private List<QuickSheet> _quickSheets;

        public DeleteQuickSheetForm(DB_Integrator dbIntegrator)
        {
            InitializeComponent();
            _dbIntegrator = dbIntegrator;
        }

        private async void DeleteQuickSheetForm_Load(object sender, EventArgs e)
        {
            await LoadQuickSheets();
        }

        private async Task LoadQuickSheets()
        {
            string query = "SELECT id, name, description FROM quick_sheets";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            _quickSheets = new List<QuickSheet>();

            foreach (DataRow row in dataTable.Rows)
            {
                _quickSheets.Add(new QuickSheet
                {
                    Id = Convert.ToInt32(row["id"]),
                    Name = row["name"].ToString(),
                    Description = row["description"].ToString()
                });
            }

            quickSheetComboBox.DataSource = _quickSheets;
            quickSheetComboBox.DisplayMember = "DisplayName";
            quickSheetComboBox.ValueMember = "Id";
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            QuickSheet selectedSheet = (QuickSheet)quickSheetComboBox.SelectedItem;
            if (selectedSheet != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the QuickSheet '{selectedSheet.DisplayName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // First, delete associated records in quick_sheet_products
                    string deleteProductsQuery = $"DELETE FROM quick_sheet_products WHERE quick_sheet_id = {selectedSheet.Id}";
                    await _dbIntegrator.QueryAsync(deleteProductsQuery, null);

                    // Then, delete the record in quick_sheets
                    string deleteQuery = $"DELETE FROM quick_sheets WHERE id = {selectedSheet.Id}";
                    await _dbIntegrator.QueryAsync(deleteQuery, null);

                    MessageBox.Show("QuickSheet deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadQuickSheets();
                }
            }
            else
            {
                MessageBox.Show("Please select a QuickSheet to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
