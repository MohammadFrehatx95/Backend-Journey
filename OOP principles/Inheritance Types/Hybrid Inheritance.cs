public class Program
{
    public static void Main(string[] args)
    {
        Developer developer = new Developer();

        developer.Name = "Mohammad";

        developer.Work();
        developer.WriteCode();
        developer.AttendMeeting();
    }
}

public class Employee
{
    public string Name { get; set; } = string.Empty;

    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}

public interface ICoder
{
    void WriteCode();
}

public interface IMeeting
{
    void AttendMeeting();
}

public class Developer : Employee, ICoder, IMeeting
{
    public void WriteCode()
    {
        Console.WriteLine($"{Name} is writing code.");
    }

    public void AttendMeeting()
    {
        Console.WriteLine($"{Name} is attending a meeting.");
    }
}
