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

        emp.EmployeeCheckStatus();
    }

    public enum EmployeeStatus
    {
        Active = 1,
        OnLeave = 2,
        Suspended = 3,
        Terminated = 4
    }

    public class Employee : IEmployeeCheckStatus
    {
        public string Name { get; set; }

        public EmployeeStatus Status { get; set; }

        public void EmployeeCheckStatus()
        {
            switch (Status)
            {
                case EmployeeStatus.Active:
                    Console.WriteLine("Employee is active");
                    break;

                case EmployeeStatus.OnLeave:
                    Console.WriteLine("Employee is on leave");
                    break;

                case EmployeeStatus.Suspended:
                    Console.WriteLine("Employee is suspended");
                    break;

                case EmployeeStatus.Terminated:
                    Console.WriteLine("Employee is terminated");
                    break;

                default:
                    Console.WriteLine("Unknown employee status");
                    break;
            }
        }
    }

    public interface IEmployeeCheckStatus
    {
        void EmployeeCheckStatus();
    }
}
