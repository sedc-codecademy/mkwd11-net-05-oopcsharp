// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void SayHello()
{
    Console.WriteLine("Hello");
}

void SayHelloTo(string name)
{
    Console.WriteLine("Hello " + name);
}

int Sum(int num1, int num2)
{
    return num1 + num2;
}

double Divide(int num1, double num2)
{
    return num1 / num2;
}

string JediMindTrick()
{
    return "There aren't the droids you are looking for.";
}

string CheckDroids(bool isJedi)
{
    if(isJedi)
    {
        return JediMindTrick();
    }
    else
    {
        return "Take the droids. It's cool.";
    }
}

bool CheckIfNumberIsValid(string number)
{
    bool isValidNumber = int.TryParse(number, out int result);
    return isValidNumber;
}

string GetInputFromScreen()
{
    string input = Console.ReadLine();
    return input;
}

int ParseStringToNumber(string input)
{
    int parsedNumebr = int.Parse(input);
    return parsedNumebr;
}

string ReadNumberFromScreen()
{
    string input = GetInputFromScreen();

    if(!CheckIfNumberIsValid(input))
    {
        return "Not valid number";
    }

    int number = ParseStringToNumber(input);

    switch(number)
    {
        case 0:
            return "Zero";
        case 1:
            return "One";
        case 2:
            return "Two";
        case 3:
            return "Three";
        default:
            return "Very large number";
    }
}


int Multiply(int num1, int num2)
{
    return num1 * num2;
}

int Substract(int num1, int num2)
{
    return num1 - num2;
}

void Exercise()
{
    // get operation sign
    Console.WriteLine("Enter an opration (* or -): ");
    string operation = Console.ReadLine();

    // validate operation
    if(operation != "*" && operation != "-")
    {
        Console.WriteLine("Sorry! Wrong input!");
        return;
    }

    // get numbers from screen
    Console.WriteLine("Enter first number: ");
    string number1 = Console.ReadLine();
    Console.WriteLine("Enter second number: ");
    string number2 = Console.ReadLine();

    // parse numbers
    int parseNum1 = int.Parse(number1);
    int parseNum2 = int.Parse(number2);

    // validate number
    // for homework

    // execute asked operation
    if(operation == "*")
    {
        int result = Multiply(parseNum1, parseNum2);
        Console.WriteLine(result);
    } else if (operation == "-")
    {
        int result = Substract(parseNum1, parseNum2);
        Console.WriteLine(result);
    }
}



// calling methods
SayHello();
SayHelloTo("Trajan");
int result = Sum(1, 2);
Console.WriteLine(result);
double result2 = Divide(10, 3);
Console.WriteLine(result2);

string result3 = CheckDroids(true);
Console.WriteLine(result3);
string result4 = CheckDroids(false);
Console.WriteLine(result4);

string result5 = ReadNumberFromScreen();
Console.WriteLine(result5);

Exercise();