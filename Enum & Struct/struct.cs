public class Program
{
    public static void Main()
    {
        ProductDimensions product1 = new ProductDimensions(10,20,30);

        ProductDimensions product2 = product1;

        product2.Width = 50;

        Console.WriteLine(product1.Width);
        Console.WriteLine(product2.Width);
    }

    public struct ProductDimensions
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public ProductDimensions(float w, float h, float d)
        {
            Width = w;
            Height = h;
            Depth = d;
        }

    }
}
