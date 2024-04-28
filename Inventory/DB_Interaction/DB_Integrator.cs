using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Inventory.DB_Interaction
{
    public class DB_Integrator
    {

        private NpgsqlConnection dataSource;

        public DB_Integrator()
        {
            
            this.dataSource = new NpgsqlConnection(GetConnectionString());
        }

        static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public async Task Open()
        {
            await dataSource.OpenAsync();
        }
        public async Task Close()
        {
            await dataSource.CloseAsync();
        }

        public async Task Query(string sql, string[] args)
        {
            await Open();
            try
            {
                string formattedString = sql;
                if (args != null) { formattedString = string.Format(sql, args); }
                Console.WriteLine(formattedString);
                using var command = new NpgsqlCommand(formattedString, dataSource);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            await Close();
        }
        public async Task<object?> Select(string sql, string[] args)
        {
            StringBuilder result = new StringBuilder();
            await Open();
            try
            {
                string formattedString = sql;
                if (args != null) { formattedString = string.Format(sql, args); }
                
                using var command = new NpgsqlCommand(formattedString, dataSource);
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result.Append(reader.GetValue(i).ToString() + " "); // Append each column value followed by a space
                    }
                    result.AppendLine(); // New line for each row
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            await Close();
            return result.ToString();
        }

        


    }
}
