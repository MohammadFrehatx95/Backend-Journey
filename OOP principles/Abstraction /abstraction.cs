public class Program
{
    public static void Main()
    {
        Developer developer = new Developer
        {
            Id = 1,
            Name = "Mohammad",
            Salary = 1000
        };

        Manager manager = new Manager
        {
            Id = 2,
            Name = "Omar",
            Salary = 2000
        };

        developer.PrintInfo();
        Console.WriteLine($" Developer Bouns : {developer.CalculateBonus()}");
        developer.GenerateReport();

        manager.PrintInfo();
        Console.WriteLine($" Manager Bouns : {manager.CalculateBonus()}");
        manager.GenerateReport();

    }

    public abstract class Employee { 

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Employee Id: {Id}, Employee Name: {Name}, Employee Salary: {Salary}");
        }
        public abstract decimal CalculateBonus();
    }

    public class Developer : Employee, IReportable
    {
        public override decimal CalculateBonus()
        {
            return Salary * 0.10m;
        }

        public void GenerateReport()
        {
            Console.WriteLine($"Employee Id: {Id}, Employee Name: {Name}, Employee Salary {Salary}, Specialist: Developer");
        }
    }

    public class Manager : Employee, IReportable
    {
        public override decimal CalculateBonus()
        {
            return Salary * 0.20m;
        }

        public void GenerateReport()
        {
            Console.WriteLine($"Employee Id: {Id}, Employee Name: {Name}, Employee Salary {Salary}, Specialist: Manager");
        }
    }
    public interface IReportable
    {
        void GenerateReport();
    }

}
