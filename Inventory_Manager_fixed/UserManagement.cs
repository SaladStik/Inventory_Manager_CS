using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.DB_Interaction;

namespace Inventory_Manager
{
    public partial class UserManagement : Form
    {
        private readonly DB_Integrator _dbIntegrator;
        string _firstname = "";
        string _lastname = "";
        string _username = "";
        public UserManagement(DB_Integrator dbIntegrator)
        {
            InitializeComponent();
            _dbIntegrator = dbIntegrator;
            LoadUsersAsync().GetAwaiter().GetResult(); // Load users when the form is initialized
            LoadRolesAsync().GetAwaiter().GetResult(); // Load roles when the form is initialized

            UserList_DataGrid.DataBindingComplete += UserList_DataGrid_DataBindingComplete; // Attach DataBindingComplete event
        }

        private async Task LoadUsersAsync()
        {
            string query = @"
                SELECT u.username, u.first_name, u.last_name, r.role_name, u.forgot_password 
                FROM users u 
                JOIN roles r ON u.role_id = r.id";
            DataTable userTable = await _dbIntegrator.GetDataTableAsync(query, null);
            UserList_DataGrid.DataSource = userTable;

            // Hide unnecessary columns
            foreach (DataGridViewColumn column in UserList_DataGrid.Columns)
            {
                if (column.Name != "forgot_password")
                {
                    column.ReadOnly = true; // Make sure all columns are read-only
                }
            }

            UserList_DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async Task LoadRolesAsync()
        {
            string query = "SELECT id, role_name FROM roles";
            DataTable rolesTable = await _dbIntegrator.GetDataTableAsync(query, null);

            Role_ComboBox.DataSource = rolesTable;
            Role_ComboBox.DisplayMember = "role_name";
            Role_ComboBox.ValueMember = "role_name";

            SetRole_ComboBox.DataSource = rolesTable.Copy();
            SetRole_ComboBox.DisplayMember = "role_name";
            SetRole_ComboBox.ValueMember = "role_name";
        }

        private void UserList_DataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in UserList_DataGrid.Rows)
            {
                bool forgotPassword = Convert.ToBoolean(row.Cells["forgot_password"].Value);
                if (forgotPassword)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private async void CreateUser_Button_Click(object sender, EventArgs e)
        {
            string username = Username_TextBox.Text.Trim();
            string firstName = FirstName_TextBox.Text.Trim();
            string lastName = LastName_TextBox.Text.Trim();
            string roleName = Role_ComboBox.SelectedValue.ToString();
            string password = "welcome"; // Set a default password or prompt the user to enter one

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve role ID based on role name
            string roleQuery = "SELECT id FROM roles WHERE role_name = @role_name";
            var roleParams = new Dictionary<string, object> { { "@role_name", roleName } };
            DataTable roleTable = await _dbIntegrator.GetDataTableWithParametersAsync(roleQuery, roleParams);

            if (roleTable.Rows.Count == 0)
            {
                MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roleId = Convert.ToInt32(roleTable.Rows[0]["id"]);

            await CreateUserAsync(username, password, firstName, lastName, roleId);

            MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadUsersAsync(); // Reload users
        }

        private async Task CreateUserAsync(string username, string password, string firstName, string lastName, int roleId)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltBytes = new byte[16];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(saltBytes);
                }
                string salt = Convert.ToBase64String(saltBytes);
                string passwordHash = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt)));

                string query = "INSERT INTO users (username, password, salt, first_name, last_name, role_id) VALUES (@username, @password, @salt, @first_name, @last_name, @role_id)";
                var parameters = new Dictionary<string, object>
                {
                    { "@username", username },
                    { "@password", passwordHash },
                    { "@salt", salt },
                    { "@first_name", firstName },
                    { "@last_name", lastName },
                    { "@role_id", roleId }
                };

                await _dbIntegrator.QueryWithParametersAsync(query, parameters);
            }
        }

        private async void RemoveUser_Button_Click(object sender, EventArgs e)
        {
            if (UserList_DataGrid.SelectedRows.Count > 0)
            {
                string username = UserList_DataGrid.SelectedRows[0].Cells["username"].Value.ToString();

                string query = "DELETE FROM users WHERE username = @username";
                var parameters = new Dictionary<string, object> { { "@username", username } };

                await _dbIntegrator.QueryWithParametersAsync(query, parameters);

                MessageBox.Show("User removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsersAsync(); // Reload users
            }
            else
            {
                MessageBox.Show("Please select a user to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SetRole_Button_Click(object sender, EventArgs e)
        {
            if (UserList_DataGrid.SelectedRows.Count > 0)
            {
                string username = UserList_DataGrid.SelectedRows[0].Cells["username"].Value.ToString();
                string newRoleName = SetRole_ComboBox.SelectedValue.ToString();

                string roleQuery = "SELECT id FROM roles WHERE role_name = @role_name";
                var roleParams = new Dictionary<string, object> { { "@role_name", newRoleName } };
                DataTable roleTable = await _dbIntegrator.GetDataTableWithParametersAsync(roleQuery, roleParams);

                if (roleTable.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int newRoleId = Convert.ToInt32(roleTable.Rows[0]["id"]);

                string query = "UPDATE users SET role_id = @role_id WHERE username = @username";
                var parameters = new Dictionary<string, object>
                {
                    { "@role_id", newRoleId },
                    { "@username", username }
                };

                await _dbIntegrator.QueryWithParametersAsync(query, parameters);

                MessageBox.Show("User role updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsersAsync(); // Reload users
            }
            else
            {
                MessageBox.Show("Please select a user to set role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ResetUserPassword_Button_Click(object sender, EventArgs e)
        {
            if (UserList_DataGrid.SelectedRows.Count > 0)
            {
                string username = UserList_DataGrid.SelectedRows[0].Cells["username"].Value.ToString();
                using (var setPasswordForm = new SetPasswordForm(username, _dbIntegrator))
                {
                    if (setPasswordForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadUsersAsync(); // Reload users
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SetUserPassword_Button_Click(object sender, EventArgs e)
        {
            if (UserList_DataGrid.SelectedRows.Count > 0)
            {
                string username = UserList_DataGrid.SelectedRows[0].Cells["username"].Value.ToString();

                using (var setPasswordForm = new SetPasswordForm(username, _dbIntegrator))
                {
                    if (setPasswordForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadUsersAsync(); // Reload users after password reset
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to set password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Username_TextBox_TextChanged(object sender, EventArgs e)
        {

        }


        //Auto generate usernames
        private void FirstName_TextBox_TextChanged(object sender, EventArgs e)
        {
            _firstname = FirstName_TextBox.Text.Trim();
            _username = _firstname + "." + _lastname;

            if (FirstName_TextBox.Text.Length > 0 && LastName_TextBox.Text.Length > 0)
            {
                Username_TextBox.Text = _username;
            }
            else
            {
                Username_TextBox.Text = "";
            }
        }

        //Auto generate usernames
        private void LastName_TextBox_TextChanged(object sender, EventArgs e)
        {
            _lastname = LastName_TextBox.Text.Trim();
            _username = _firstname + "." + _lastname;

            if (FirstName_TextBox.Text.Length > 0 && LastName_TextBox.Text.Length > 0)
            {
                Username_TextBox.Text = _username;
            }
            else
            {
                Username_TextBox.Text = "";
            }
        }
    }
}
