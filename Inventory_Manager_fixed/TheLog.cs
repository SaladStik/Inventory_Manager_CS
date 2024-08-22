using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class TheLog : Form
    {
        private int _productID;
        private DB_Integrator _dbIntegrator;

        public TheLog(int productID)
        {
            InitializeComponent();
            _productID = productID;
            _dbIntegrator = new DB_Integrator();
            LoadLogData();
        }

        private async void LoadLogData()
        {
            try
            {
                string query = $"SELECT event_id, users_id, date, previous_value, new_value, field_updated, serial_number FROM the_log WHERE product_id = {_productID} ORDER BY date DESC";
                DataTable dataTable = await _dbIntegrator.GetDataTableAsync(query, null);

                var logEntries = dataTable.AsEnumerable().Select(row => new LogEntry
                {
                    EventId = row["event_id"].ToString(),
                    UserId = Convert.ToInt32(row["users_id"]),
                    Date = Convert.ToDateTime(row["date"]),
                    PreviousValue = row["previous_value"]?.ToString() ?? string.Empty,
                    NewValue = row["new_value"]?.ToString() ?? string.Empty,
                    FieldUpdated = row["field_updated"]?.ToString() ?? string.Empty,
                    SerialNumber = row["serial_number"]?.ToString() ?? string.Empty
                }).ToList();

                var logDisplayData = new List<LogDisplayEntry>();
                foreach (var log in logEntries)
                {
                    string eventDescription = await GetDescriptiveEvent(log);
                    logDisplayData.Add(new LogDisplayEntry
                    {
                        EventId = log.EventId,
                        Date = log.Date.ToString("yyyy-MM-dd HH:mm:ss"),
                        Event = eventDescription
                    });
                }

                theLogsTrueForm.DataSource = logDisplayData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading log data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetDescriptiveEvent(LogEntry log)
        {
            try
            {
                string userName = await GetUserNameById(log.UserId);
                string eventDescription;
                int diff = 0;

                if (int.TryParse(log.PreviousValue, out int prevValue) && int.TryParse(log.NewValue, out int newValue))
                {
                    diff = newValue - prevValue;
                }

                diff = Math.Abs(diff);

                switch (log.EventId)
                {
                    case "E001":
                        eventDescription = $"{userName} updated {log.FieldUpdated} from '{log.PreviousValue}' to '{log.NewValue}'.";
                        break;
                    case "E002":
                        eventDescription = $"{userName} added {diff} items to stock.";
                        break;
                    case "E004":
                        eventDescription = $"{userName} removed {Math.Abs(diff)} items from stock.";
                        break;
                    case "E003":
                        eventDescription = $"{userName} created a product.";
                        break;
                    case "E005":
                        eventDescription = $"{userName} updated {log.FieldUpdated} for {log.SerialNumber} from '{log.PreviousValue}' to '{log.NewValue}'.";
                        break;
                    case "E006":
                        eventDescription = $"{userName} printed a label.";
                        break;
                    case "E007":
                        eventDescription = $"{userName} logged in.";
                        break;
                    default:
                        eventDescription = $"{userName} performed an action.";
                        break;
                }

                return eventDescription;
            }
            catch (Exception ex)
            {
                return $"Error generating event description: {ex.Message}";
            }
        }

        private async Task<string> GetUserNameById(int userId)
        {
            try
            {
                string query = $"SELECT username FROM users WHERE id = {userId}";
                object result = await _dbIntegrator.SelectAsync(query, null);
                return result?.ToString() ?? "Unknown";
            }
            catch (Exception ex)
            {
                return $"Error retrieving username: {ex.Message}";
            }
        }
    }

    public class LogEntry
    {
        public string EventId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string PreviousValue { get; set; }
        public string NewValue { get; set; }
        public string FieldUpdated { get; set; }
        public string SerialNumber { get; set; } // Add this line
    }

    public class LogDisplayEntry
    {
        public string EventId { get; set; }
        public string Date { get; set; }
        public string Event { get; set; }
    }
}
