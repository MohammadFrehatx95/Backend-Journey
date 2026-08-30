public class Program
{
    public static void Main()
    {
        Employee employee = new Employee
        {
            Id = 1,
            Name = "Omar",
            Age = 30,
            Phone = "0777123456"
        };

        employee.PrintInfo();
        employee.PrintContactInfo();
    }

    public class Employee : IPrintable, IContactable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
        }

        public void PrintContactInfo()
        {
            Console.WriteLine($"Employee: {Name}, Phone: {Phone}");
        }
    }

    public interface IPrintable
    {
        void PrintInfo();
    }

    public interface IContactable
    {
        void PrintContactInfo();
    }
}
