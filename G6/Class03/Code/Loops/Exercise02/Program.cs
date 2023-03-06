Console.WriteLine("====Even numbers=====");
Console.WriteLine("Enter first number");
string firstInput = Console.ReadLine();

int firstNumber;
bool firstSuccess = int.TryParse(firstInput, out firstNumber);

if (firstSuccess)
{
    for(int i = 2; i <= firstNumber; i++)
    {
        if(i % 2 == 0)
        {
            Console.WriteLine("i: " + i);
        }
    }

    for(int i =2; i <= firstNumber; i = i + 2) //i+=2
    {
        Console.WriteLine("i: " + i);
    }
}
else
{
    Console.WriteLine("Invalid input");
}

Console.WriteLine("====Odd numbers=====");
Console.WriteLine("Enter second number");
string secondInput = Console.ReadLine();

int secondNumber;
bool secondSuccess = int.TryParse(secondInput, out secondNumber);

if (secondSuccess)
{
    for(int i = secondNumber; i >= 1; i--)
    {
        if(i % 2 != 0) // (i % 2 == 1)
        {
            Console.WriteLine("i: " + i);
        }
    }
}
else
{
    Console.WriteLine("Invalid input");
}