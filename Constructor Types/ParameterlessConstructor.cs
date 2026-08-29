public class Program
{
    public static void Main()
    {
        Product product = new Product();

        Console.Write(product.Name + " " + product.Price);

    }

    public class Product
    {
        public Product() // Parameterless Constructor
        {
            Name = "Unknown Product";
            Price = 0;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }  
    }
}
