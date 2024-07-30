using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class SetPasswordForm : Form
    {
        private readonly string _username;
        private readonly DB_Integrator _dbIntegrator;

        public SetPasswordForm(string username, DB_Integrator dbIntegrator)
        {
            InitializeComponent();
            _username = username;
            _dbIntegrator = dbIntegrator;
        }

        public string NewPassword => newPasswordTextBox.Text;

        private async void setPasswordButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newPasswordTextBox.Text))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            // Hash the new password
            using (var sha256 = SHA256.Create())
            {
                var saltBytes = new byte[16];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(saltBytes);
                }
                string salt = Convert.ToBase64String(saltBytes);
                string passwordHash = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(newPasswordTextBox.Text + salt)));

                string query = @"
                    UPDATE users 
                    SET password = @password, salt = @salt, forgot_password = @forgot_password 
                    WHERE LOWER(username) = @username"; // Convert username to lowercase in the query
                var parameters = new Dictionary<string, object>
                {
                    { "@password", passwordHash },
                    { "@salt", salt },
                    { "@forgot_password", false },
                    { "@username", _username }
                };

                await _dbIntegrator.QueryWithParametersAsync(query, parameters);

                MessageBox.Show("User password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
