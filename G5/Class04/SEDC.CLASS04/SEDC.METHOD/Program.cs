#region Method

Console.WriteLine("=== VOID====");
// Function with no parameters, no return (void) 
void Hello()
{
    Console.WriteLine("Hello from SEDC");
    Console.ReadLine();
}
// This method takes in two integers and writes their sum to the console
void PrintSum(int numberOne, int numberTwo)
{
    //Hello();
    int sum = numberOne + numberTwo;
    Console.WriteLine($"The sum of {numberOne} and {numberTwo} is: {sum}");
}


Console.WriteLine("=== Double ====");
// Function with parameters and return

double DoubleMethod(double num1, double num2)
{
    return num1 / num2;
}
Console.WriteLine("=== Integer ====");
int SumTwoNumber(int num1, int num2)
{
    //DoubleMethod();
    int sumTwoNumber = num1 + num2;
    return sumTwoNumber;
}

Console.WriteLine("=== String ====");

string PrintHello()
{
    return "Hello from SEDC";
}

Console.WriteLine("=== Boolean ====");

bool CheckSucc(bool isTrue)
{
    if (isTrue)
    {
        int results = SumTwoNumber(2, 5);// We can call functions inside of functions
        Console.WriteLine(results);
        return true;
    }
    return false;
   
}

Console.WriteLine("=== Integer in Void ====");
// Function with parameters but no reutrn ( void )
// This method takes in a bool value and writes a message to the console based on its value
void PrintMessage(bool isSucc)
{
    if (isSucc)
    {
        SumTwoNumber(2, 4);
        Console.WriteLine("Its was succ");
    }
    else
    {
        Console.WriteLine("Faild!");
    }
}


#endregion

#region Exercise
Console.WriteLine("Enter first number: ");
string inputFirstNum = Console.ReadLine();
bool inputFirstNumCheck = int.TryParse(inputFirstNum, out int parsedInputFirstNum);
Console.WriteLine("Enter second number: ");
string inputSecondNum = Console.ReadLine();
bool inputSecondNumCheck = int.TryParse(inputSecondNum, out int parsedInputSecondNum);
int Sum(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}
int Subtract(int num1, int num2)
{
    int subtract = num1 - num2;
    return subtract;
}
bool whileLoop = true;
while (whileLoop)
{
    if (inputFirstNumCheck && inputSecondNumCheck)
    {
        Console.WriteLine("Enter '+' or '-'");
        //Console.WriteLine(@"Enter ""+"" or ""-"" ");
        string inputOperator = Console.ReadLine();
        switch (inputOperator)
        {
            case "+":
                Console.WriteLine(Sum(parsedInputFirstNum, parsedInputSecondNum));
                whileLoop = false;
                break;
            case "-":
                Console.WriteLine(Subtract(parsedInputFirstNum, parsedInputSecondNum));
                whileLoop = false;
                break;
            default:
                Console.WriteLine("Wrong operator! Please try again");
                break;
        }
    }
}


Console.WriteLine("======== Second =========");
int Sum1(int num1, int num2)
{
    return num1 + num2;
}

int Subtract1(int num1, int num2)
{
    return num1 - num2;
}

void Exercise1()
{
    Console.Write("Enter an operation ( + or - ):");
    string operation = Console.ReadLine();
    if (operation != "+" && operation != "-")
    {
        Console.WriteLine("Sorry! Wrong input!");
        return;
    }
    Console.Write("Enter first number:");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second number:");
    int number2 = int.Parse(Console.ReadLine());
    if (operation == "+") Console.WriteLine(Sum1(number1, number2));
    if (operation == "-") Console.WriteLine(Subtract1(number1, number2));

}
#endregion

// Calling the methods
Hello();
PrintSum(5, 8);
// We can store return values in a variable
int num1 = 10;
int num2 = 12;
PrintSum(num1, num2);
Console.WriteLine("Double method" + DoubleMethod(2.2, 6.5));
Console.WriteLine("Integer method" + SumTwoNumber(4, 6));
Console.WriteLine("String method" + PrintHello());
Console.WriteLine("Boolean method" + CheckSucc(true));
// Or use it on the spot where we need the result
PrintMessage(true);
// Exercise 1
Exercise1();