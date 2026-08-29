public class Program
{
    public static void Main()
    {
        Console.WriteLine(Database.ConnectionName);
    }

    public class Database
    {
        static Database()
        {
            ConnectionName = "MainDatabase";
        }
        public static string ConnectionName { get; set; }
    }
}
