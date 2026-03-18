namespace InventoryManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager db = new DatabaseManager();
            db.InitializeDatabase();
        }
    }
}
