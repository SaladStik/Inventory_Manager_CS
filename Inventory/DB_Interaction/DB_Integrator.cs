using Npgsql;
using System;
using System.Configuration;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DB_Interaction
{
    public class DB_Integrator
    {
        private readonly string _connectionString;

        public DB_Integrator()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private async Task<NpgsqlConnection> GetOpenConnectionAsync()
        {
            var conn = new NpgsqlConnection(_connectionString);
            await conn.OpenAsync();
            return conn;
        }

        public async Task QueryAsync(string sql, params string[] args)
        {
            try
            {
                await using var conn = await GetOpenConnectionAsync();
                string formattedString = args != null && args.Length > 0 ? string.Format(sql, args) : sql;
                using var command = new NpgsqlCommand(formattedString, conn);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
                throw;
            }
        }

        public async Task<object?> SelectAsync(string sql, params string[] args)
        {
            try
            {
                await using var conn = await GetOpenConnectionAsync();
                string formattedString = args != null && args.Length > 0 ? string.Format(sql, args) : sql;
                using var command = new NpgsqlCommand(formattedString, conn);
                return await command.ExecuteScalarAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing select: {ex.Message}");
                throw;
            }
        }

        public async Task<DataTable> GetDataTableAsync(string sql, params string[] args)
        {
            DataTable dataTable = new DataTable();
            try
            {
                await using var conn = await GetOpenConnectionAsync();
                string formattedString = args != null && args.Length > 0 ? string.Format(sql, args) : sql;
                using var command = new NpgsqlCommand(formattedString, conn);
                using var adapter = new NpgsqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting data table: {ex.Message}");
                throw;
            }

            return dataTable;
        }
    }
}
