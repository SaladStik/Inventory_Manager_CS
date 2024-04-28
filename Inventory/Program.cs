/*using Npgsql;

var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=postgres";
await using var dataSource = new NpgsqlConnection(connectionString);
await dataSource.OpenAsync();

//await using var command = new NpgsqlCommand("SELECT * FROM action;",dataSource);
//await using var reader = await command.ExecuteReaderAsync();
var name = "";

Console.WriteLine("Enter Name: ");
name = Console.ReadLine();

await using var command = new NpgsqlCommand($"INSERT INTO action(name) VALUES('{name}');", dataSource);
await command.ExecuteNonQueryAsync();


/*while (await reader.ReadAsync())
{
    Console.Write(reader.GetInt32(0));
    Console.Write(reader.GetString(1));
}*/

//await dataSource.CloseAsync();
