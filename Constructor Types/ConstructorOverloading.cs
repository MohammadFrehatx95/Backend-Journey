public class Program
{
    public static void Main()
    {
       Employee emp1 = new Employee();
       Employee emp2 = new Employee("Mohammad");
       Employee emp3 = new Employee("Omar", 200);

    }

    public class Employee
    {
        public Employee()
        {
            Name = "Unknown Employee";
            Salary = 0;
        }

        public Employee(string name)
        {
            Name = name;
        }

        public Employee(string name , decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }
    }
}
