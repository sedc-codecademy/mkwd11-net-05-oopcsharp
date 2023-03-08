int Sum(int num1, int num2)
{
    return num1 + num2;
}

int Subtract(int num1, int num2)
{
    return num1 - num2;
}

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
    Console.WriteLine("Enter + or -");
    string op = Console.ReadLine();

    if(op == "+")
    {
        int sum = Sum(firstNumber, secondNumber);
        Console.WriteLine("The sum is " + sum);
    }
    else if(op == "-")
    {
        int result = Subtract(firstNumber, secondNumber);
        Console.WriteLine("The difference is " + result);
    }
    else
    {
        Console.WriteLine("Invalid operator!");
    }
}