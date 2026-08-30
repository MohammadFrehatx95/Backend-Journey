public class Program
{
    public static void Main()
    {
        Employee emp = new Employee
        {
            Name = "Mohammad",
            Status = EmployeeStatus.Active
        };

        Console.WriteLine($"Name: {emp.Name}");
        Console.WriteLine($"Status: {emp.Status}");
    }


    public enum EmployeeStatus
    {
        Active = 1,
        OnLeave = 2,
        Suspended = 3,
        Terminated = 4,
    }

    public class Employee
    {
        public string Name { get; set; }

        public EmployeeStatus Status { get; set; }
    }
    


}
