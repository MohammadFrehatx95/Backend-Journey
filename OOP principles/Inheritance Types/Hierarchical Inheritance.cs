public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();

        dog.Name = "Rocky";

        dog.Eat();
        dog.Bark();


        Cat cat = new Cat();

        cat.Name = "Luna";

        cat.Eat();
        cat.Meow();
    }
}

public class Animal
{
    public string Name { get; set; } = string.Empty;

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine($"{Name} is meowing.");
    }
}
