int age = 17;

if (age >= 18)
    Console.WriteLine("Adult");
else if (age >= 13)
    Console.WriteLine("Teen");
else
    Console.WriteLine("Child");

// --------------- IF Completed ------------------------

for(int i = 0; i <= 5; i++)
{
    Console.WriteLine($"{i}, Hello World.");  // Interpolation
}

// --------------- FOR Completed ------------------------

string[] names = { "Mohammmad", "Ahmad", "Omar", "Sami" };

foreach(string name in names)
{
    Console.WriteLine(name);
}

// --------------- FOREACH Completed ------------------------

int counter = 0;

while(counter < 5)
{
    Console.WriteLine("Enter a Odd Number!");
    counter++;
}

// --------------- WHILE Completed ------------------------

int c = 0;
do
{
    Console.WriteLine("This Code Will Execute Only Once!");

} while (c != 0);

// --------------- DO-WHILE Completed ------------------------
