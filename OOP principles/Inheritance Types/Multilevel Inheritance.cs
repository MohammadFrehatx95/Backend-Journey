public class Program
{
    public static void Main(string[] args)
    {
        Manager manager = new Manager();

        manager.Name = "Mohammad";

        manager.Work();
        manager.ManageTeam();
        manager.CreateReport();
    }
}

public class Employee
{
    public string Name { get; set; }

    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}

public class Supervisor : Employee
{
    public void ManageTeam()
    {
        Console.WriteLine($"{Name} is managing the team.");
    }
}

public class Manager : Supervisor
{
    public void CreateReport()
    {
        Console.WriteLine($"{Name} is creating a report.");
    }
}
