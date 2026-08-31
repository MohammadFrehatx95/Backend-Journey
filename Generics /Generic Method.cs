public class Program
{
    public static void Main()
    {
      DisplayService ds = new DisplayService();

        ds.Display<int>(10);
        ds.Display<string>("Hello");
        ds.Display<decimal>(100.5m);
    }

    public class DisplayService
    {
        public void Display<T>(T value)
        {
            Console.WriteLine($"Value: {value}, Type: {value.GetType()}");
        }
    }
}
