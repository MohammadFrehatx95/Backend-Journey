public class Program
{
    public static void Main()
    {
        Shape shape1 = new Circle(5);
        Shape shape2 = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {shape1.CalculateArea()}");
        Console.WriteLine($"Rectangle Area: {shape2.CalculateArea()}");
    }
}

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}
