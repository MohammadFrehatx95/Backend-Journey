public class Program
{
    public static void Main()
    { 
        Employee employee = new Employee("Mohammad",23); 
    }

    public class Employee
    {
        public Employee(string name, decimal salary) // Parameterized Constructor
    {
            Name = name;
            Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
}
