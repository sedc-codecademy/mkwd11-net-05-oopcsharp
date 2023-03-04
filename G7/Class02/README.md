# Class 02 - Data Types and Branching 😋

## Data Types

C# is a strictly typed language. This means that it cares about the type of values that we use as well as where and how we use them. This is why in C# we can't just use one variable keyword to write a new variable, but we need to use multiple depending on the type of data that we need to add there. We also can't change the type of a variable or put a different type in a variable that we have declared previously. We create a variable of a type and we must put the value of that type there. Some of the types are:

```markdown
|                | keyword | Range                                                   |
|----------------|---------|---------------------------------------------------------|
| Integer Number | int     | -2,147,483,648 to 2,147,483,647                         |
| Decimal Number | double  | ~15-17 precision decimal                                |
| Large Number   | long    | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| Small Number   | short   | -32,768 to 32,767                                       |
| Text (string)  | string  | ~1 billion characters                                   |
| Character      | char    | 1 character                                             |
| Boolean        | bool    | true or false                                           |
```

```csharp
int num = 5;
string words = "Hello people";
char letter = 'P';
bool falsy = false;
double deci = 0.2;
num = "Hey"; // This will be marked as an error
Console.WriteLine(num.GetType()); // Find out what type some variable is
```

### Implicit Type Variables

Implicit type variables in C# are variables that do not have an implicit type when declaring them. These variables are declared by using the **var** keyword. Although it might seem like the typical JavaScript variable and similar magic, it is not the same. C# as we know is a strongly typed language, and it would not break its own rules even in this case. The implicit type part of these variables means that they get their type later by deducting what value we put in at compile time. That means that if the compiler deducts that a variable type is Integer, it would stay integer for the rest of the execution, and we would not be able to change the type anymore

```csharp
// Implicit Type Variables
var implicitInt = 23;
var implicitString = "Hello";

implicitInt = 33; // We can change the value of the same type
implicitInt = "Hey"; // This will lead to compilation error. We can't change the type any more
```

## Data Entry

Entering data from a console can be done by typing text in the console. This is the only way a person can send some data to a console application. We can't create buttons or add events. A console application always returns a string as a result of what the user typed. Requiring and entering data is done as follows:

```csharp
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello there " + name + "!");
```

## Data Conversion

To convert data from one type to the other becomes very important when working with languages that are strictly typed. In C# we have a couple of ways of doing that. Those are:

```csharp
// Using Parse method
int parseInt = int.Parse("23");
double parseDouble = double.Parse("23.5");

// Using Convert method
int convertInt = Convert.ToInt32("23");
double convertDouble = Convert.ToDouble("23.5");

// Using TryParse method
// If the converting is successful the value will be written here
int ifParsedValue; 
// A boolean variable that will keep info if the parsing was successful or not
bool parsingSuccsess = int.TryParse("25", out ifParsedValue);
Console.WriteLine(parsingSuccsess); // true
```

## Branching

Branching and creating a different path for the code to take is a very core concept and feature of any programming language. C# is no exception. The main methods of doing this are if/else block and switch. This is the implementation of these concepts in C#:

```csharp
// If / Else 
if (5 > 3)
{
  Console.WriteLine("5 is larger than 3");
}
else
{
  Console.WriteLine("5 is not larger than 3"); 
}

// Switch 
int day = 3;

switch (day)
{
  case 1:
  case 2:
  case 3:
  case 4:
  case 5:
    Console.WriteLine("Work day :(");
    break;
  case 6:
  case 7:
    Console.WriteLine("WEEKEND! WOHO!");
    break;
  default:
    Console.WriteLine("There is no such day! Sorry!");
    break;
}
```

## Extra Materials 📘

* [Official Microsoft documentation for types](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/)
* [Official Microsoft documentation for statements](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/statements)
