// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


if (5 > 3) 
{
    Console.WriteLine("5 is larger than 3");
}
else
{
    // Visual studio tells us here that this code will never be executed
    Console.WriteLine("5 is not larger thatn 3");
}

Console.Write("Please enter a number: ");
string value = Console.ReadLine();

bool isValidNumber = int.TryParse(value, out int number);

if(!isValidNumber)
{
    Console.WriteLine("Please enter a valid number");
}
else
{
    if(number > 0)
    {
        Console.WriteLine("Number is positive");
    }
    else if(number < 0)
    {
        Console.WriteLine("Number is negative");
    }
    else
    {
        Console.WriteLine("Number is zero");
    }
}

// switch

int day = 3;
switch(day)
{
    //case 1:
    //    Console.WriteLine("Working day :(");
    //    break;
    //case 2:
    //    Console.WriteLine("Working day :(");
    //    break;
    //case 3:
    //    Console.WriteLine("Working day :(");
    //    break;
    //case 4:
    //    Console.WriteLine("Working day :(");
    //    break;
    //case 5:
    //    Console.WriteLine("Working day :(");
    //    break;
    //case 6:
    //    Console.WriteLine("Weekend");
    //    break;
    //case 7:
    //    Console.WriteLine("Weekend");
    //    break;
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Working day :(");
        break;
    case 6:
    case 7:
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("There is no such day!");
        break;
}




// Exercise 5
Console.Write("Please enter number of trees: ");
int trees = int.Parse(Console.ReadLine()); // change to try parse
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

Console.WriteLine("Please enter 2 numbers");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

// parse numbers
int number1 = int.Parse(num1);
int number2 = Convert.ToInt32(num2);
// for homework try with try parse'

int larger = 0;
if(number1 > number2)
{
    larger = number1;
    Console.WriteLine("Number one is larger");
} 
else if(number2 > number1)
{
    larger = number2;
    Console.WriteLine("Number two is larger");
}
else
{
    larger = number1;
    Console.WriteLine("They are equal");
}

if(larger != 0)
{
    if(larger % 2 == 0)
    {
        Console.WriteLine("Number is even");
    }
    else
    {
        Console.WriteLine("Number is odd");
    }
}
else
{
    Console.WriteLine("You entered Zero, That is not even nore odd !");
}
