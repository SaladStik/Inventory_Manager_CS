using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class LoadQuickSheetForm : Form
    {
        private DB_Integrator _dbIntegrator;
        private List<QuickSheet> _quickSheets;

        public LoadQuickSheetForm(DB_Integrator dbIntegrator)
        {
            InitializeComponent();
            _dbIntegrator = dbIntegrator;
            LoadQuickSheets();
        }

        private async void LoadQuickSheets()
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

        private void ViewButton_Click(object sender, EventArgs e)
        {
            QuickSheet selectedSheet = (QuickSheet)quickSheetComboBox.SelectedItem;
            if (selectedSheet != null)
            {
                ViewQuickSheet(selectedSheet.Id);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            QuickSheet selectedSheet = (QuickSheet)quickSheetComboBox.SelectedItem;
            if (selectedSheet != null)
            {
                PrintQuickSheet(selectedSheet.Id);
            }
        }

        private async void ViewQuickSheet(int quickSheetId)
        {
            string query = $"SELECT p.alias, p.bin FROM quick_sheet_products qsp JOIN product p ON qsp.product_id = p.id WHERE qsp.quick_sheet_id = {quickSheetId}";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            quickSheetDataGridView.DataSource = dataTable;
        }

        private async void PrintQuickSheet(int quickSheetId)
        {
            string query = $"SELECT p.alias, p.bin FROM quick_sheet_products qsp JOIN product p ON qsp.product_id = p.id WHERE qsp.quick_sheet_id = {quickSheetId}";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            var printDoc = new PrintDocument();
            printDoc.PrintPage += (sender, e) =>
            {
                // Define the custom font size
                Font printFont = new Font(this.Font.FontFamily, 18);

                int aliasColumnWidth = 0;
                int binColumnWidth = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    SizeF aliasSize = e.Graphics.MeasureString(row["alias"].ToString(), printFont);
                    SizeF binSize = e.Graphics.MeasureString(row["bin"].ToString(), printFont);

                    if (aliasSize.Width > aliasColumnWidth)
                        aliasColumnWidth = (int)aliasSize.Width;

                    if (binSize.Width > binColumnWidth)
                        binColumnWidth = (int)binSize.Width;
                }

                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                int rowHeight = (int)e.Graphics.MeasureString("Sample", printFont).Height + 5;

                // Print header
                e.Graphics.DrawString("Alias", printFont, Brushes.Black, x, y);
                e.Graphics.DrawString("Bin", printFont, Brushes.Black, x + aliasColumnWidth + 10, y);

                y += rowHeight;

                // Print rows
                foreach (DataRow row in dataTable.Rows)
                {
                    e.Graphics.DrawString(row["alias"].ToString(), printFont, Brushes.Black, x, y);
                    e.Graphics.DrawString(row["bin"].ToString(), printFont, Brushes.Black, x + aliasColumnWidth + 10, y);
                    y += rowHeight;
                }
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }

    public class QuickSheet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayName => $"{Name} ~ {Description}";
    }
}
