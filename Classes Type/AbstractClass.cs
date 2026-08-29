public class Program
{
    public static void Main()
    {
        Dog dog = new Dog();

        dog.Name = "Rex";

        dog.Print();
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Print();
    }

    public class Dog : Animal
    {
        public override void Print() // Override Required in Abstract Class
        {
            Console.WriteLine("Dog name:" + Name);
        }
    }
}
