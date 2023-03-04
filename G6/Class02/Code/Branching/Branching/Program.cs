//IF-ELSE
int firstNumber = 5;
int secondNumber = 3;

if (firstNumber == secondNumber)
{
    Console.WriteLine("The numbers are equal");
}
else
{
    Console.WriteLine("The numbers are not equal");
}


if (firstNumber > secondNumber)
{
    Console.WriteLine("First number is greater than second");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine("Second number is greater than first");
}
else
{
    Console.WriteLine("The numbers are equal");
}


//SWITCH
int day;
Console.WriteLine("Enter a number from 1 to 7");
string input = Console.ReadLine();

bool success = int.TryParse(input, out day);

if (success)
{
    //this if is the case when the parsing succeeded
    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Working day, it is not Monday!");
            break;
        case 6:
        case 7:
            Console.WriteLine("Weekend!");
            break;
        default:
            Console.WriteLine("Invalid value.It is a number, but not between 1 and 7");
            break;
    }
}
else
{
    //this else is the case when parsing didn't succeed
    Console.WriteLine("Invalid input");
}