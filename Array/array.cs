int[] numbers = new int[5];

numbers[0] = 50;
numbers[1] = 40;
numbers[2] = 30;
numbers[3] = 20;
numbers[4] = 10;

Console.WriteLine(numbers.Length);

// ---------------------- Task 1: Print Length ----------------------


foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// ---------------------- Task 2: Print Elements ----------------------


Array.Sort(numbers);

Console.WriteLine("Sort Array Ascending:");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// ---------------------- Task 3: Sort Ascending ----------------------


Array.Reverse(numbers);

Console.WriteLine("Reverse Array:");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

//  ---------------------- Task 4: Reverse ----------------------


Console.WriteLine("Index Of 50: " + Array.IndexOf(numbers, 50));

// ---------------------- Task 5: IndexOf  ----------------------


Array.Clear(numbers); // you can clear a specific elements

Console.WriteLine("Array Cleared:");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

//// ---------------------- Task 6: Clear  ----------------------

public class Program
{
    public static void Main()
    {
        Person[] peoples = new Person[2];

        peoples[0] = new Person{
            Name = "Mohammad",
            Age = 20
        };

        peoples[1] = new Person
        {
            Name = "OmarAbs",
            Age = 23
        };

        foreach (Person person in peoples)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
    public class Person()
    {
        public string Name { get; set; }
        public int  Age { get; set; }
    }
}
//// ---------------------- Task 7: Array Of Object  ----------------------
