Console.WriteLine("===== Branching ====");

Console.WriteLine("===Example 1 ====");  
if (45 > 31)
{
    Console.WriteLine("45 is larger than 31");
}
else
{
    Console.WriteLine("45 is not larger than 31"); // Visual studio tells us here that this code will never be executed
}

Console.WriteLine("===Example 2 ====");

int someNumber = int.Parse(Console.ReadLine());
if(someNumber > 2)
{
    Console.WriteLine(someNumber + "is large");
}
else
{
    Console.WriteLine(someNumber + "is smaller");
}

Console.WriteLine("===Example 3 ====");

string s = Console.ReadLine();

if (int.TryParse(s, out int resultNumber))
{
    Console.WriteLine("Value of parsing number" + resultNumber);
    Console.WriteLine("DataType:" + resultNumber);
}
else
{
    Console.WriteLine("The value could not be converted to a integer");
}

Console.Write("==== Exercise 5 ====== ");

// Exercise 5
Console.Write("Please enter number of trees: ");
int trees = int.Parse(Console.ReadLine());
int n = 8;
int m = 5;
int treeApples = n * 12 * trees;
int result;
if (treeApples % m == 0)
{
    result = treeApples / m;
}
else
{
    result = treeApples / m + 1;
}
Console.WriteLine("You would need :" + result + " baskets!");


// Exercise 6
Console.Write("Enter a number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter another number: ");
int num2 = int.Parse(Console.ReadLine());
int larger;
if (num1 > num2)
{
    larger = num1;
    Console.WriteLine("First is larger!");
}
else if (num2 > num1)
{
    larger = num2;
    Console.WriteLine("Second is larger!");
}
else
{
    larger = num1;
    Console.WriteLine("The numbers are equal!");
}

if (larger != 0)
{
    if (larger % 2 == 0)
    {
        Console.WriteLine("Number is Even!");
    }
    else if (larger % 2 != 0)
    {
        Console.WriteLine("Number is Odd!");
    }
}
else
{
    Console.WriteLine("You entered Zero. That is not even nore odd!");
}

