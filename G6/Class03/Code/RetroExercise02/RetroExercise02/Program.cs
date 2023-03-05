Console.WriteLine("Enter first number");
string firstInput = Console.ReadLine();

Console.WriteLine("Enter second number");
string secondInput = Console.ReadLine();


int firstNumber;
int secondNumber;

bool firstSuccess = int.TryParse(firstInput, out firstNumber);
bool secondSuccess = int.TryParse(secondInput, out secondNumber);

if(firstSuccess && secondSuccess)
{
    if(firstNumber % 2 == 0)
    {
        Console.WriteLine("First number is an even number");
    }
    else
    {
        Console.WriteLine("First number is an odd number");
    }

    if (secondNumber % 2 == 0)
    {
        Console.WriteLine("Second number is an even number");
    }
    else
    {
        Console.WriteLine("Second number is an odd number");
    }
}
else
{
    Console.WriteLine("At least one input was incorrect");
}

//Second way
if (firstSuccess)
{
    if (firstNumber % 2 == 0)
    {
        Console.WriteLine("First number is an even number");
    }
    else
    {
        Console.WriteLine("First number is an odd number");
    }
}
else
{
    Console.WriteLine("First input was incorrect");
}

if (secondSuccess)
{
    if (secondNumber % 2 == 0)
    {
        Console.WriteLine("Second number is an even number");
    }
    else
    {
        Console.WriteLine("Second number is an odd number");
    }
}
else
{
    Console.WriteLine("Second input was incorrect");
}


if (!firstSuccess)
{
    Console.WriteLine("First input was incorrect");
}

Console.WriteLine("This is code that will get executed anyway");