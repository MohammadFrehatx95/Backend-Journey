public class Program
{
    public static void Main()
    {
        Employee employee = new Employee();

        employee.Name = "Mohammad";
        employee.Salary = 500;

        employee.PrintInfo();
    }
}

// Part 1
public partial class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

// Part 2
public partial class Employee
{
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
    }
}
