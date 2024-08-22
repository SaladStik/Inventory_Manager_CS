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
    public partial class LoadJobs : Form
    {
        private DB_Integrator _dbIntegrator;
        private List<Job> _jobs;
        private Dictionary<(int jobId, int productId), (int oldQuantity, int newQuantity)> _changedQuantities; // Track changes
        private int _jobId;
        public LoadJobs(DB_Integrator dbIntegrator)
        {
            InitializeComponent();
            _dbIntegrator = dbIntegrator;
            _changedQuantities = new Dictionary<(int jobId, int productId), (int oldQuantity, int newQuantity)>();
            LoadJobsData();
        }

        private async void LoadJobsData()
        {
            string query = "SELECT id, tkt_num, name, description FROM jobs WHERE job_active = true";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            _jobs = new List<Job>();

            foreach (DataRow row in dataTable.Rows)
            {
                _jobs.Add(new Job
                {
                    Id = Convert.ToInt32(row["id"]),
                    TicketNumber = row["tkt_num"].ToString(),
                    Name = row["name"].ToString(),
                    Description = row["description"].ToString()
                });
            }

            JobComboBox.DataSource = _jobs;
            JobComboBox.DisplayMember = "DisplayName";
            JobComboBox.ValueMember = "Id";
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Job selectedJob = (Job)JobComboBox.SelectedItem;
            if (selectedJob != null)
            {
                ViewJob(selectedJob.Id);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Job selectedJob = (Job)JobComboBox.SelectedItem;
            if (selectedJob != null)
            {
                PrintJob(selectedJob.Id);
            }
        }

        private async void ViewJob(int jobId)
        {
            _jobId = jobId;
            string query = $"SELECT p.id, p.alias, p.bin, jp.product_quantity, jp.product_original_quantity, p.quantity as stock_quantity FROM jobs_products jp JOIN product p ON jp.product_id = p.id WHERE jp.job_id = {jobId}";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            JobDataGridView.DataSource = dataTable;
            JobDataGridView.Columns["id"].Visible = false; // Hide the product ID column
            JobDataGridView.Columns["alias"].HeaderText = "Alias";
            JobDataGridView.Columns["bin"].HeaderText = "Bin";
            JobDataGridView.Columns["product_quantity"].HeaderText = "Quantity";
            JobDataGridView.Columns["product_original_quantity"].HeaderText = "Original Quantity";
            JobDataGridView.Columns["stock_quantity"].HeaderText = "Stock Quantity";
            JobDataGridView.Columns["alias"].ReadOnly = true; // Make alias column read-only
            JobDataGridView.Columns["bin"].ReadOnly = true; // Make bin column read-only
            JobDataGridView.Columns["stock_quantity"].ReadOnly = true; // Make stock quantity column read-only
            JobDataGridView.Columns["product_original_quantity"].ReadOnly = true; // Make original quantity column read-only
        }

        private async void PrintJob(int jobId)
        {
            string query = $"SELECT p.alias, p.bin, jp.product_quantity, jp.product_original_quantity FROM jobs_products jp JOIN product p ON jp.product_id = p.id WHERE jp.job_id = {jobId}";
            DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

            var printDoc = new PrintDocument();
            printDoc.PrintPage += (sender, e) =>
            {
                // Define the custom font size
                Font printFont = new Font(this.Font.FontFamily, 18);

                int aliasColumnWidth = 0;
                int binColumnWidth = 0;
                int quantityColumnWidth = 0;
                int originalQuantityColumnWidth = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    SizeF aliasSize = e.Graphics.MeasureString(row["alias"].ToString(), printFont);
                    SizeF binSize = e.Graphics.MeasureString(row["bin"].ToString(), printFont);
                    SizeF quantitySize = e.Graphics.MeasureString(row["product_quantity"].ToString(), printFont);
                    SizeF originalQuantitySize = e.Graphics.MeasureString(row["product_original_quantity"].ToString(), printFont);

                    if (aliasSize.Width > aliasColumnWidth)
                        aliasColumnWidth = (int)aliasSize.Width;

                    if (binSize.Width > binColumnWidth)
                        binColumnWidth = (int)binSize.Width;

                    if (quantitySize.Width > quantityColumnWidth)
                        quantityColumnWidth = (int)quantitySize.Width;

                    if (originalQuantitySize.Width > originalQuantityColumnWidth)
                        originalQuantityColumnWidth = (int)originalQuantitySize.Width;
                }

                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                int rowHeight = (int)e.Graphics.MeasureString("Sample", printFont).Height + 5;

                // Print header
                e.Graphics.DrawString("Alias", printFont, Brushes.Black, x, y);
                e.Graphics.DrawString("Bin", printFont, Brushes.Black, x + aliasColumnWidth + 10, y);
                e.Graphics.DrawString("Quantity", printFont, Brushes.Black, x + aliasColumnWidth + binColumnWidth + 20, y);
                e.Graphics.DrawString("Original Quantity", printFont, Brushes.Black, x + aliasColumnWidth + binColumnWidth + quantityColumnWidth + 30, y);

                y += rowHeight;

                // Print rows
                foreach (DataRow row in dataTable.Rows)
                {
                    e.Graphics.DrawString(row["alias"].ToString(), printFont, Brushes.Black, x, y);
                    e.Graphics.DrawString(row["bin"].ToString(), printFont, Brushes.Black, x + aliasColumnWidth + 10, y);
                    e.Graphics.DrawString(row["product_quantity"].ToString(), printFont, Brushes.Black, x + aliasColumnWidth + binColumnWidth + 20, y);
                    e.Graphics.DrawString(row["product_original_quantity"].ToString(), printFont, Brushes.Black, x + aliasColumnWidth + binColumnWidth + quantityColumnWidth + 30, y);
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

        private void JobDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == JobDataGridView.Columns["product_quantity"].Index)
            {
                JobDataGridView.BeginEdit(true);
            }
        }

        private void JobDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == JobDataGridView.Columns["product_quantity"].Index)
            {
                int productId = Convert.ToInt32(JobDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                int jobId = (int)JobComboBox.SelectedValue;
                int newQuantity = Convert.ToInt32(JobDataGridView.Rows[e.RowIndex].Cells["product_quantity"].Value);
                int stockQuantity = Convert.ToInt32(JobDataGridView.Rows[e.RowIndex].Cells["stock_quantity"].Value);
                int originalQuantity = Convert.ToInt32(JobDataGridView.Rows[e.RowIndex].Cells["product_original_quantity"].Value);

                if (newQuantity < 0)
                {
                    MessageBox.Show("Quantity cannot be less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    JobDataGridView.Rows[e.RowIndex].Cells["product_quantity"].Value = originalQuantity; // Reset to original quantity
                    return;
                }

                if (newQuantity > (stockQuantity + originalQuantity))
                {
                    MessageBox.Show("Quantity cannot be greater than available stock plus original quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    JobDataGridView.Rows[e.RowIndex].Cells["product_quantity"].Value = originalQuantity; // Reset to original quantity
                    return;
                }

                if (_changedQuantities.ContainsKey((jobId, productId)))
                {
                    _changedQuantities[(jobId, productId)] = (originalQuantity, newQuantity);
                }
                else
                {
                    _changedQuantities.Add((jobId, productId), (originalQuantity, newQuantity));
                }
            }
        }

        private async void JobSaveButton_Click(object sender, EventArgs e)
        {
            foreach (var kvp in _changedQuantities)
            {
                (int jobId, int productId) = kvp.Key;
                (int oldQuantity, int newQuantity) = kvp.Value;
                int quantityDifference = newQuantity - oldQuantity;

                // Update jobs_products table
                string query = $"UPDATE jobs_products SET product_quantity = @newQuantity, product_original_quantity = @newQuantity WHERE product_id = @productId AND job_id = @jobId";
                var parameters = new Dictionary<string, object>
                {
                    { "@newQuantity", newQuantity },
                    { "@productId", productId },
                    { "@jobId", jobId }
                };
                await _dbIntegrator.QueryWithParametersAsync(query, parameters);

                // Update product stock quantity
                string updateStockQuery = $"UPDATE product SET quantity = quantity - @quantityDifference WHERE id = @productId";
                var stockParameters = new Dictionary<string, object>
                {
                    { "@quantityDifference", quantityDifference },
                    { "@productId", productId }
                };
                await _dbIntegrator.QueryWithParametersAsync(updateStockQuery, stockParameters);

                // Log the change
                string logEventId = quantityDifference > 0 ? "E004" : "E002"; // E004 for removal, E002 for addition
                int logQuantity = Math.Abs(quantityDifference); // Ensure positive quantity for logging
                string logQuery = $@"
                    INSERT INTO the_log (event_id, users_id, product_id, date, previous_value, new_value, field_updated, serial_number)
                    VALUES (@eventId, @userId, @productId, @date, @oldQuantity, @logQuantity, 'quantity', @serialNumber)";

                var logParameters = new Dictionary<string, object>
                {
                    { "@eventId", logEventId },
                    { "@userId", UserSession.UserId },
                    { "@productId", productId },
                    { "@date", DateTime.Now },
                    { "@oldQuantity", oldQuantity },
                    { "@logQuantity", logQuantity },
                    { "@serialNumber", productId } // Assuming productId is used as serial number
                };
                await _dbIntegrator.QueryWithParametersAsync(logQuery, logParameters);
            }

            _changedQuantities.Clear();
            MessageBox.Show("Job quantities have been saved successfully.");

            // Refresh the job view
            if (JobComboBox.SelectedItem != null)
            {
                ViewJob(((Job)JobComboBox.SelectedItem).Id);
            }
        }

        private async void End_Job_Button_Click(object sender, EventArgs e)
        {
            Job selectedJob = (Job)JobComboBox.SelectedItem;
            if (selectedJob != null)
            {
                string query = $"UPDATE jobs SET job_active = false WHERE id = @jobId";
                var parameters = new Dictionary<string, object>
                {
                    { "@jobId", selectedJob.Id }
                };

                await _dbIntegrator.QueryWithParametersAsync(query, parameters);
                MessageBox.Show("Job ended successfully.");

                // Reload the job data to show only active jobs
                LoadJobsData();
                ViewJob(_jobId);
            }
        }
    }

    public class Job
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayName => $"{TicketNumber} - {Name} - {Description}";
    }
}
