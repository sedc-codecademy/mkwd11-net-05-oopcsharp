// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//returnType MethodName()
//body

//Method that has no input parameters and no return type
using System.Security.Cryptography.X509Certificates;

void Afirmation() 
{
    Console.WriteLine("No matter how hard it gets, you should never give up");
}

//call the method
Afirmation();

//Method with no return type, with input parameters

void PermitForDrink (int age)
{
    if (age <= 18)
    {
        Console.WriteLine("You are not old enought to drink, grow up :)");

    }
    else {
        Console.WriteLine("You are old enought to buy drinks, go get a beer");
    }
}

//Call the method
//PermitForDrink(25);
Console.WriteLine("Please enter your age");
int UserAge = int.Parse(Console.ReadLine());
PermitForDrink(UserAge);

//method with return type and no input parameters

string WeekendMind()
{
    string result = "The weekend is best spent with friends";
    return result;
}

//Call the method
string res = WeekendMind();
Console.WriteLine(res);

//Method with return type and input parameter
string DayOfTheWeek (int day)
{
    string result;
    switch (day) {
        case 1:
            result = "Today is Monday";
            break;
        case 2:
            result = "Today is Tuesday";
            break;
        case 3:
            result = "Today is Wednesday";
            break;
        case 4:
            result = "Today is Thursday";
            break;
        case 5:
            result = "Today is Friday";
            break;
        case 6:
            result = "Today is Saturday";
            break;
        case 7:
            result = "Today is Sunday";
            break;
        default:
            result = "You entered invalid day";
            break;
    }
    return result;
}

string EnteredDay = DayOfTheWeek(10);
Console.WriteLine(EnteredDay);

//Method with two input parameters

string Introduction (string InputName, int InputDay)
{
    string ResultDayOfTheWeek = DayOfTheWeek(InputDay);
    string result = "Nice to meet you " + InputName + ", " + ResultDayOfTheWeek + " , enjoy it";
    return result;
}

Console.WriteLine("Hello, what is your name:");
string userName = Console.ReadLine();
Console.WriteLine("Please insert number:");
int userNumber = Convert.ToInt32(Console.ReadLine());
string userResult = Introduction(userName, userNumber);
Console.WriteLine(userResult);

//Exercise 1

int Sum (int num1,int num2)
{
    return num1+ num2;
}
int Subtract(int num1,int num2)
{
    return num1 - num2;
}

int Calculator(char operations,int num1,int num2)
{
    int result =0;
    if(operations == '+')
    {
        result = Sum(num1, num2);
    }
    else if(operations == '-')
    {
        result = Subtract(num1, num2);
    }
    return result;
}
Console.WriteLine("Enter operations");
char op = char.Parse(Console.ReadLine());
Console.WriteLine("Enter num 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num 2");
int number2 = Convert.ToInt32(Console.ReadLine());
 

int Res = Calculator(op, number1, number2);
Console.WriteLine(Res);


