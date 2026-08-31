public class Program
{
    public static void Main()
    {
       Employee employee = new Employee
       {
           Id = 1,
           Name = "Mohammad",
           Status = EmployeeStatus.Active
       };

       EmployeeManager empManager = new EmployeeManager();

        empManager.Add(employee);
        empManager.Print(employee);
    }
    
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeStatus Status { get; set; }
    }

    public class EmployeeManager : IManager<Employee>
    {
        public void Add(Employee item)
        {
            Console.WriteLine($"Employee Added Successfully");
        }

        public void Print(Employee item)
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Status: {item.Status}");
        }
    }
    public enum EmployeeStatus
    {
        Active,
        OnLeave,
        Terminated
    }

    public interface IManager<T>
    {
        void Add(T item);
        void Print(T item);
    }
}
