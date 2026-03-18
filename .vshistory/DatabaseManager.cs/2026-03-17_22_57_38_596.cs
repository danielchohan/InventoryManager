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

        }
        

        public List<Item> GetAllItems()
        {
            var items = new List<Item>();


            return items;
        }

        public List<Item> GetByName()
        {
            var items = new List<Item>();
        }
    }
}
