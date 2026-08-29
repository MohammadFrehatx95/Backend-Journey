public class Program
{
    public static void Main()
    {
        Company.Employee emp = new Company.Employee();
        emp.Name = "Mohammad";
        Console.WriteLine(emp.Name);
    }

    public class Company
    {
        public class Employee
        {
            public string Name { get; set; }
        }
    }
}
