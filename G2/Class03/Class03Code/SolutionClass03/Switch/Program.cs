//Case example
int DayOfTheWeek = 1;

switch (DayOfTheWeek)
{
    case 1:
        Console.WriteLine("Today is Monday");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday");
        break;
    case 4:
        Console.WriteLine("Today is Thursday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}


//Case example, calculator

double FirstNumber;
double SecondNumber;
double Result;
char operation;

Console.WriteLine("Enter the first number");
FirstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number");
SecondNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the operator");
operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
    case '+':
        Result = FirstNumber + SecondNumber;
        Console.WriteLine(Result);
        break;
    case '-':
        Result = FirstNumber - SecondNumber;
        Console.WriteLine(Result);
        break;
    case '*':
        Result = FirstNumber * SecondNumber;
        Console.WriteLine(Result);
        break;
    case '/':
        Result = FirstNumber / SecondNumber;
        Console.WriteLine(Result);
        break;
    default:
        Console.WriteLine("You entered invalid operator");
        break;


}

Console.WriteLine("Please insert a number and get a reward.");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("You got a new car!");
        break;
    case 2:
        Console.WriteLine("You got a new plane!");
        break;
    case 3:
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("ERROR! No reward for you! :(");
        break;

}