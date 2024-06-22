using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory_Manager
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void DB_AUTH_BUTTON_Click(object sender, EventArgs e)
        {
            if (VerifySettings())
            {
                UpdateConfiguration();
                MessageBox.Show("Settings updated successfully.");
            }
            else
            {
                MessageBox.Show("Invalid settings. Please check the values entered.");
            }
        }

        private bool VerifySettings()
        {
            // Add your verification logic here
            // Example: Check if the database server IP is a valid IP address or hostname
            // Check if the username and password are not empty
            // Check if the image server path is a valid UNC path
            // This is just a basic example, you may need to add more comprehensive checks

            if (string.IsNullOrWhiteSpace(DB_SERVER_IP_TEXT.Text) ||
                string.IsNullOrWhiteSpace(DB_USERNAME_AUTH_TEXT.Text) ||
                string.IsNullOrWhiteSpace(DB_PASSWORD_AUTH_TEXT.Text) ||
                string.IsNullOrWhiteSpace(DB_IMAGES_SERVER_PATH.Text))
            {
                return false;
            }

            // Additional checks can be added here as needed
            return true;
        }

        private void UpdateConfiguration()
        {
            // Load the configuration file
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Get the connectionStrings section
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

            // Find the connection string by name
            var connectionStringSettings = connectionStringsSection.ConnectionStrings["DefaultConnection"];

            if (connectionStringSettings != null)
            {
                var connectionStringParts = connectionStringSettings.ConnectionString.Split(';');

                for (int i = 0; i < connectionStringParts.Length; i++)
                {
                    if (connectionStringParts[i].StartsWith("Host="))
                    {
                        connectionStringParts[i] = "Host=" + DB_SERVER_IP_TEXT.Text;
                    }
                    else if (connectionStringParts[i].StartsWith("Username="))
                    {
                        connectionStringParts[i] = "Username=" + DB_USERNAME_AUTH_TEXT.Text;
                    }
                    else if (connectionStringParts[i].StartsWith("Password="))
                    {
                        connectionStringParts[i] = "Password=" + DB_PASSWORD_AUTH_TEXT.Text;
                    }
                }

                connectionStringSettings.ConnectionString = string.Join(";", connectionStringParts);

                // Save the configuration file
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
            }
            else
            {
                MessageBox.Show("DefaultConnection not found in the configuration file.");
            }
        }


        private void DB_SERVER_IP_BUTTON_Click(object sender, EventArgs e)
        {
            if (VerifySettings())
            {
                UpdateConfiguration();
                MessageBox.Show("Database server IP updated successfully.");
            }
            else
            {
                MessageBox.Show("Invalid settings. Please check the values entered.");
            }
        }
    }
}