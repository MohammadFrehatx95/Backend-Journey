public class Program
{
    public static void Main()
    {
        Product p1 = new Product("Laptop", 4000);
        Product p2 = new Product(p1);

        p2.Name = "Phone";
        Console.WriteLine(p1.Name);
        Console.WriteLine(p2.Name); // They are Different Objects not ref to same loc
    }

    public class Product
    {
        public Product(string name, decimal price) 
        {
            Name = name;
            Price = price;
        }

        public Product(Product Other) // Copy Constructor
        {
            Name = Other.Name;
            Price = Other.Price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
