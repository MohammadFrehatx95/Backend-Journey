public class Program
{
    public static void Main()
    {
        Employee emp = new Employee();
        emp.Name = "Mohammad";
    }

    public class Employee // Normal class : instantiated directly to create objects
    {
        public  string Name { get; set; }
    }
}
