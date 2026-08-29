public class Program
{
    public static void Main()
    {
        Console.WriteLine(Calculator.Add(5, 10));
    }

    public static class Calculator
    {
        public static int Add(int a , int b)
        {
            return a + b;    
        }
    }
}

