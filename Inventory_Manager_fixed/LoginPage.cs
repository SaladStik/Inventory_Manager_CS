using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class LoginPage : Form
    {
        private readonly DB_Integrator _dbIntegrator;

        public LoginPage()
        {
            InitializeComponent();
            _dbIntegrator = new DB_Integrator();

            // Attach the KeyDown event handler to the text boxes
            Username_TextBox.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            Password_TextBox.KeyDown += new KeyEventHandler(TextBox_KeyDown);
        }

        private async void SignIn_Button_Click(object sender, EventArgs e)
        {
            string username = Username_TextBox.Text.ToLower(); // Convert username to lowercase
            string password = Password_TextBox.Text;

            if (await ValidateUserAsync(username, password))
            {
                // Reset forgot_password flag if it was set
                await ResetForgotPasswordFlagAsync(username);

                // Check if the password is "welcome"
                if (password == "welcome")
                {
                    MessageBox.Show("You must change your password before proceeding.", "Change Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SetPasswordForm setPasswordForm = new SetPasswordForm(username, _dbIntegrator);
                    if (setPasswordForm.ShowDialog() == DialogResult.OK)
                    {
                        password = setPasswordForm.NewPassword; // Update password with the new one
                    }
                    else
                    {
                        ErrorMessage_Label.Text = "Password change is required.";
                        ErrorMessage_Label.Visible = true;
                        return;
                    }
                }

                // Save the authenticated user details
                UserSession.UserId = await GetUserIdAsync(username);
                UserSession.Username = username;
                UserSession.Role = await GetUserRoleAsync(username);

                // Hide the login form and show the main form
                this.Hide();
                Form1 mainForm = new Form1(); // Pass username to Form1
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                ErrorMessage_Label.Text = "Invalid username or password.";
                ErrorMessage_Label.Visible = true;
            }
        }

        private async Task<int> GetUserIdAsync(string username)
        {
            string query = "SELECT id FROM users WHERE LOWER(username) = @username"; // Convert username to lowercase in the query
            var parameters = new Dictionary<string, object> { { "@username", username } };

            DataTable userTable = await _dbIntegrator.GetDataTableWithParametersAsync(query, parameters);

            if (userTable.Rows.Count > 0)
            {
                return Convert.ToInt32(userTable.Rows[0]["id"]);
            }

            throw new Exception("User ID not found.");
        }

        private async Task<bool> ValidateUserAsync(string username, string password)
        {
            try
            {
                string query = "SELECT password, salt FROM users WHERE LOWER(username) = @username"; // Convert username to lowercase in the query
                var parameters = new Dictionary<string, object> { { "@username", username } };

                DataTable userTable = await _dbIntegrator.GetDataTableWithParametersAsync(query, parameters);

                if (userTable.Rows.Count == 0)
                {
                    Console.WriteLine("No user found with the provided username.");
                    return false;
                }

                DataRow userRow = userTable.Rows[0];
                string storedPasswordHash = userRow["password"].ToString();
                string salt = userRow["salt"].ToString();

                using (var sha256 = SHA256.Create())
                {
                    string passwordHash = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt)));
                    bool isValid = storedPasswordHash == passwordHash;
                    Console.WriteLine($"Stored hash: {storedPasswordHash}");
                    Console.WriteLine($"Computed hash: {passwordHash}");
                    Console.WriteLine($"IsValid: {isValid}");
                    return isValid;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during validation: {ex.Message}");
                return false;
            }
        }

        private async Task<string> GetUserRoleAsync(string username)
        {
            string query = @"
                SELECT r.role_name 
                FROM users u 
                JOIN roles r ON u.role_id = r.id 
                WHERE LOWER(u.username) = @username"; // Convert username to lowercase in the query
            var parameters = new Dictionary<string, object> { { "@username", username } };

            DataTable roleTable = await _dbIntegrator.GetDataTableWithParametersAsync(query, parameters);

            if (roleTable.Rows.Count > 0)
            {
                return roleTable.Rows[0]["role_name"].ToString();
            }

            return string.Empty;
        }

        private async void ForgotPassword_Button_Click(object sender, EventArgs e)
        {
            string username = Username_TextBox.Text.Trim().ToLower(); // Convert username to lowercase

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE users SET forgot_password = @forgot_password WHERE LOWER(username) = @username"; // Convert username to lowercase in the query
            var parameters = new Dictionary<string, object>
            {
                { "@forgot_password", true },
                { "@username", username }
            };

            await _dbIntegrator.QueryWithParametersAsync(query, parameters);

            MessageBox.Show("A request to reset your password has been sent.\nPlease contact your administrator.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task ResetForgotPasswordFlagAsync(string username)
        {
            string query = "UPDATE users SET forgot_password = @forgot_password WHERE LOWER(username) = @username"; // Convert username to lowercase in the query
            var parameters = new Dictionary<string, object>
            {
                { "@forgot_password", false },
                { "@username", username }
            };

            await _dbIntegrator.QueryWithParametersAsync(query, parameters);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignIn_Button_Click(this, new EventArgs());
                e.Handled = true; // Mark the event as handled
                e.SuppressKeyPress = true; // Suppress the default behavior of the Enter key
            }
        }
    }
}
