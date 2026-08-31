public class Program
{
    public static void Main()
    {
        Employee employee = new Employee
        {
            Name = "Mohammad",
            Age = 25,
            Salary = 500m
        };


        // 1) Class Constraint
        // Employee is allowed because it is a Reference Type.
        Storage<Employee> storage = new Storage<Employee>();
        storage.Item = employee;


        // 2) Interface Constraint
        // Employee is allowed because it implements IPrintable.
        Printer<Employee> printer = new Printer<Employee>();
        printer.PrintItem(storage.Item);


        // 3) Struct Constraint
        // int is allowed because it is a Value Type.
        NumberBox<int> numberBox = new NumberBox<int>();
        numberBox.Value = 100;
        Console.WriteLine($"Number: {numberBox.Value}");


        // 4) Base Class Constraint
        // Employee is allowed because it inherits from Person.
        PersonBox<Employee> personBox = new PersonBox<Employee>();
        personBox.Person = employee;
        personBox.PrintName();


        // 5) new() Constraint
        // Employee is allowed because it has a public parameterless constructor.
        ObjectFactory<Employee> factory = new ObjectFactory<Employee>();
        
        Employee newEmployee = factory.Create();

        newEmployee.Name = "Ahmad";
        newEmployee.Age = 30;
        newEmployee.Salary = 700m;

        Console.WriteLine(
            $"Created Employee: {newEmployee.Name}, " +
            $"Age: {newEmployee.Age}, " +
            $"Salary: {newEmployee.Salary}"
        );
    }


    // Base Class
    // Contains common data shared by derived classes.
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    // Derived Class
    // Inherits from Person and implements IPrintable.
    public class Employee : Person, IPrintable
    {
        // Required by the new() constraint.
        public Employee()
        {
        }

        public decimal Salary { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}" );
        }
    }


    // Class Constraint
    // T must be a Reference Type.
    public class Storage<T> where T : class
    {
        public T Item { get; set; }
    }


    // Struct Constraint
    // T must be a Value Type.
    public class NumberBox<T> where T : struct
    {
        public T Value { get; set; }
    }


    // Interface Contract
    // Any implementing class must provide Print().
    public interface IPrintable
    {
        void Print();
    }


    // Interface Constraint
    // T must implement IPrintable.
    public class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print();
        }
    }


    // Base Class Constraint
    // T must be Person or a class derived from Person.
    public class PersonBox<T> where T : Person
    {
        public T Person { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"Person Name: {Person.Name}");
        }
    }

    // new() Constraint
    // T must have a public parameterless constructor.
    public class ObjectFactory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
