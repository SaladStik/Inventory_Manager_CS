using System;
using System.Windows.Forms;
using Inventory.DB_Interaction;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;

namespace Inventory_Manager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DB_Integrator dbIntegrator = new DB_Integrator();
            AddDefaultAdminUserAsync(dbIntegrator).GetAwaiter().GetResult(); // Add default admin user

            Application.Run(new LoginPage());
        }

        private static async Task AddDefaultAdminUserAsync(DB_Integrator dbIntegrator)
        {
            string username = "admin";
            string password = "admin";
            string firstName = "Admin";
            string lastName = "User";

            // Check if the admin user already exists
            string query = "SELECT COUNT(*) FROM users WHERE username = @username";
            var parameters = new Dictionary<string, object> { { "@username", username } };
            object result = await dbIntegrator.SelectWithParametersAsync(query, parameters);

            if (Convert.ToInt32(result) > 0)
            {
                return; // Admin user already exists
            }

            // Get the role ID for Administrator
            string roleQuery = "SELECT id FROM roles WHERE role_name = 'Administrator'";
            DataTable roleTable = await dbIntegrator.GetDataTableWithParametersAsync(roleQuery, null);

            if (roleTable.Rows.Count == 0)
            {
                return; // No Administrator role found
            }

            int roleId = Convert.ToInt32(roleTable.Rows[0]["id"]);

            using (var sha256 = SHA256.Create())
            {
                var saltBytes = new byte[16];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(saltBytes);
                }
                string salt = Convert.ToBase64String(saltBytes);
                string passwordHash = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt)));

                string insertQuery = "INSERT INTO users (username, password, salt, first_name, last_name, role_id) VALUES (@username, @password, @salt, @first_name, @last_name, @role_id)";
                var insertParameters = new Dictionary<string, object>
                {
                    { "@username", username },
                    { "@password", passwordHash },
                    { "@salt", salt },
                    { "@first_name", firstName },
                    { "@last_name", lastName },
                    { "@role_id", roleId }
                };

                await dbIntegrator.QueryWithParametersAsync(insertQuery, insertParameters);
            }
        }
    }
}
