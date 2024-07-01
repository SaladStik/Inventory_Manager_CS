using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class LoginForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Username = textBoxUsername.Text.Trim();
            Password = textBoxPassword.Text.Trim();
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
