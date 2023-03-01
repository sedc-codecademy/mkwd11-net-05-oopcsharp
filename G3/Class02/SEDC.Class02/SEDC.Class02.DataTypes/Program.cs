// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int integerVariable = 5;
int integerVariable1;
short shortVariable = 120;
long longerVariable = 123213123123213213;
byte byteVariable = 255;

integerVariable1 = -100;
integerVariable1 = 20;

integerVariable = 10000;

// longerVariable = "Trajan"; // cannot add new type in variable

Console.WriteLine(integerVariable);
Console.WriteLine(integerVariable1);
Console.WriteLine(longerVariable);


float floatVariable = 2.5f; // f is to tell teh compiler that this is single precision number
double doubleVariable = 2.5d;

Console.WriteLine(floatVariable);
Console.WriteLine(doubleVariable);



string stringVariable = "Hello Sedc!";
char charVariable = 'a';
// string character = "a"; // this is not the same with char

bool isValid = true;
bool hasPassed = false;

Console.WriteLine(stringVariable);
Console.WriteLine(charVariable);
Console.WriteLine(isValid);
Console.WriteLine(hasPassed);

// Implicitly typed variables take the type of the value
var name = "Trajan";
// The type can't be chagned later, like in JavaScript
// name = 5;

DateTime date = DateTime.Now;
Console.WriteLine(date);