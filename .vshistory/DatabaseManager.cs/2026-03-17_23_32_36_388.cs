using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class DatabaseManager
    {
        private const string ConnectionString = "Data Source=inventory.db;";

        public void InitializeDatabase()
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Items (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Category TEXT,
                Quantity INTEGER,
                Price REAL
                )";
            command.ExecuteNonQuery();
        }
        public void AddItem(Item item)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Items (Name, Category, Quantity, Price)
                VALUES ($name, $category, $quantity, $price";
            command.Parameters.AddWithValue("$name", item.Name);
            command.Parameters.AddWithValue("$category", item.Category);
            command.Parameters.AddWithValue($"quantity", item.Quantity);
            command.Parameters.AddWithValue($"price", item.Price);
        }
        

        public List<Item> SelecttAllItems()
        {
            var items = new List<Item>();


            return items;
        }

        public List<Item> SelectByName()
        {
            var items = new List<Item>();

            return items;
        }
    }
}
