public class Program
{
    public static void Main()
    {
        Box<int> intBox = new Box<int>();
        Box<string> strBox = new Box<string>();
        Box<Employee> empBox = new Box<Employee>();

        intBox.Value = 100;
        strBox.Value = "Omar";
        empBox.Value = new Employee
        {
            Name = "Osama",
            Age = 20
        };

        intBox.PrintValue();
        strBox.PrintValue();
        Console.WriteLine($"Name: {empBox.Value.Name}, Age: {empBox.Value.Age}");

    }
    public class Box<T>
    {
        public T Value { get; set; }

        public void PrintValue()
        {
            Console.WriteLine($"The Value is: {Value}");
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
