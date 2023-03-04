


// TIPS:
// In order to comment one or multiple lines use the shortcut: Ctrl + k + c
// In order to uncomment one or multiple lines use the shortcut: Ctrl + k +u



#region Variables: Declaration and Initialization

// Declaration
int number;
number = 80;


// Declaration and Initialization in one line
int year = 2023;
int theBiggestInt = -2147483647;

short shortNumber = 10;
long longNumber = 123456722334;

double doubleValue = 5.29876543;
float floatValue = 5.2543f;
decimal decimalNumber = 10.25436543m;

bool isRaining = false;


char gender = 'M';
string fullName = "Martin Panovski";




Console.WriteLine(number);
Console.WriteLine(longNumber);
Console.WriteLine(shortNumber);
Console.WriteLine(doubleValue);
Console.WriteLine(floatValue);
Console.WriteLine(decimalNumber);

Console.WriteLine(isRaining);

Console.WriteLine(year);
Console.WriteLine(theBiggestInt);
Console.WriteLine(gender);
Console.WriteLine(fullName);

#endregion

Console.WriteLine("=====================================");

#region Operators

int number1 = 500;
int number2 = 223;

int sum = number1 + number2;
Console.WriteLine("The sum is: " + sum);

int diff = number1 - number2;
Console.WriteLine("The difference is: " + diff);


int multiply = number1 * number2;
Console.WriteLine("The multiplication is: " + multiply);


double num1 = 500;
double num2 = 223;

double divide = num1 / num2;
Console.WriteLine("The division is: " + divide);

int number_1 = 230;

// By dividing with zero, an exception of type: System.DivideByZeroException occures
//double divideByZero = number_1 / 0;
//Console.WriteLine(divideByZero);




#endregion

Console.WriteLine("=====================================");

#region Data entry and Data type conversion

// How to collect user input from the console
//Console.WriteLine("Please insert your name:");
//string userInput = Console.ReadLine();
//Console.WriteLine("Hello there " + userInput);


// Data type conversion using .Parse() method
//Console.WriteLine("Enter first number:");
//int userInput1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter second number:");
//int userInput2 = int.Parse(Console.ReadLine());

//Console.WriteLine("You entered " + userInput1 + " " + userInput2);



//Console.WriteLine("Enter third number:");
//double userInput3 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter fourth number:");
//int userInput4= Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("You entered " + userInput3 + " " + userInput4);


Console.WriteLine("Please enter number");
bool userInput5 = int.TryParse(Console.ReadLine(), out int resultNumber);

//Console.WriteLine("TryParse result is: " + userInput5 + " The result of parsing is: " + resultNumber);

#endregion

Console.WriteLine("=====================================");

#region Branching (if/else and switch)

if (userInput5)
{
    Console.WriteLine("You have entered: " + resultNumber);
}
else
{
    Console.WriteLine("Wrong input. Please enter a number!");
}


Console.WriteLine("Please enter number");
int userNum1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter number");
int userNum2 = int.Parse(Console.ReadLine());

if (userNum1 != 0 && userNum2 != 0)
{
    if (userNum1 > userNum2)
    {
        Console.WriteLine("The first entered number is bigger!");
    }
    else if (userNum1 < userNum2)
    {
        Console.WriteLine("The second entered number is bigger!");
    }
    else
    {
        Console.WriteLine("The entered numbers are equal");
    }
}
else
{
    Console.WriteLine("Zero is not countered!");
}

//Console.WriteLine(typeof(userNum1));


string day = "Monday";

string userInputDay = Console.ReadLine();

switch (userInputDay.ToLower())
{
    case "monday":
        Console.WriteLine("Today is Monday");
        break;
    case "tuesday":
        Console.WriteLine("Today is Tuesday");
        break;
    case "wednesday":
        Console.WriteLine("Today is Wednesday");
        break;
    case "thursday":
        Console.WriteLine("Today is Thursday");
        break;
    case "friday":
        Console.WriteLine("Today is Friday");
        break;
    case "saturday":
        Console.WriteLine("Today is Saturday");
        break;
    case "sunday":
        Console.WriteLine("Today is Sunday");
        break;
    default:
        Console.WriteLine("Non existing day");
        break;
}


switch (userInputDay.ToLower())
{
    case "monday":
    case "wednesday":
        Console.WriteLine("Today we learn c#");
        break;
    case "tuesday":
        Console.WriteLine("Today is Tuesday");
        break;
    case "thursday":
        Console.WriteLine("Today is Thursday");
        break;
    case "friday":
        Console.WriteLine("Today is Friday");
        break;
    case "saturday":
        Console.WriteLine("Today is Saturday");
        break;
    case "sunday":
        Console.WriteLine("Today is Sunday");
        break;
    default:
        Console.WriteLine("Non existing day");
        break;
}

#endregion


#region Class Exercises Solutions

// Exercise 1

double firstNumber = 10;
double secondNumber = 22.9;

double resultDivide = firstNumber / secondNumber;
Console.WriteLine(resultDivide);


int firstNum = 44;
int secondNum = 34;

double res = firstNumber / secondNumber;
Console.WriteLine(res);


// Exercise 2

string fName = "Filip ";
string lName = "Petkov";
string resultName = fName + lName;
Console.WriteLine(resultName);


string numAsString1 = "9";
string numAsString2 = "3";
string numAsStringResult = numAsString1 + numAsString2;
Console.WriteLine(numAsStringResult);



// Exercise 3
// Using the previously declared variables I am directly jumping on the result variable

// REMINDER: In order to use '+' sign for variable of type string and integer, the result variable 
//           must be of type string!!!

string mixedResult = fName + numAsString1;
Console.WriteLine(mixedResult);


// Exercise 4
int mobileCredit = 102;
int singleMessagePrice = 5;
double maxNumberOfMessagesSent = mobileCredit / singleMessagePrice;
Console.WriteLine(maxNumberOfMessagesSent);


// Exercise 5
int numOfBranches = 12;
int numOfApplesOnBranch = 8;
double basketCapacity = 5;

Console.WriteLine("Please insert number of trees:");
bool isUserInputParsed = int.TryParse(Console.ReadLine(), out int numOfTrees);
if(isUserInputParsed)
{
    int totalBranches = numOfBranches * numOfTrees;
    double totalApples = totalBranches * numOfApplesOnBranch;
    double basketNumber = totalApples / basketCapacity;
    if(basketNumber % 2 != 0)
    {
        // Math.Ceiling() is a method so that if a decimal number is passed as parameter,
        // it will always return the next whole number as result
        basketNumber = Math.Ceiling(basketNumber); 
    }
    Console.WriteLine("When you have " + numOfTrees + 
                      " with total of " + totalApples + 
                      " apples on them, you need " + basketNumber + 
                      " to collect all the apples");
}

// Exercise 6
Console.WriteLine("Please enter whole number: ");
bool canFirstBeparsed = int.TryParse(Console.ReadLine(), out int numberInput1);
Console.WriteLine("Please enter whole number: ");
bool canSecondBeparsed = int.TryParse(Console.ReadLine(), out int numberInput2);

if(canFirstBeparsed && canSecondBeparsed)
{
    // Greater than check
    if(numberInput1 > numberInput2)
    {
        if(number1 % 2 == 0)
        {
            Console.WriteLine(numberInput1 + " is greater than " + numberInput2 + " and it is an Even number");
        }
        else
        {
            Console.WriteLine(numberInput1 + " is greater than " + numberInput2 + " and it is an Odd number");
        }
    }
    else if(numberInput1 < numberInput2)
    {
        if (number1 % 2 == 0)
        {
            Console.WriteLine(numberInput2 + " is greater than " + numberInput1 + " and it is an Even number");
        }
        else
        {
            Console.WriteLine(numberInput2 + " is greater than " + numberInput1 + " and it is an Odd number");
        }
        
    }
    else
    {
        Console.WriteLine("The numbers are equal!");
    }
}


// Exercise 5
bool canBeParsed = int.TryParse(Console.ReadLine(), out int userNumberInput);
if(canBeParsed)
{
    switch (userNumberInput)
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
            Console.WriteLine("Oops! Something went wrong!");
            break;
    }
}
#endregion


Console.ReadLine();

