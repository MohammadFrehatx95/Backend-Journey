using System

int age = 10;
long id = 0;
float floatNumber = 13.4f;
double doubNum = 13.4000;
bool isActive = true;
char letter = 'A';
string name = "Mohammad Frehat";

struct PersonInfo
{
    public string Name;
    public int Age;
}

enum OrderStatus
{
    Pending,
    Shipped,
    Delivered
}

//// -------------- Task 1 Completed --------------

int x = 10;
int y = x;
Console.WriteLine(y); // copy the value ( Value Type )

//// -------------- Task 2 Completed --------------


public class Program
{
    public static void Main()
    {
        Person p1 = new Person("Mohammad");
        Person p2 = p1;  // copy the Address (Reference Type)
    }


    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

}

//// -------------- Task 3 Completed --------------+
