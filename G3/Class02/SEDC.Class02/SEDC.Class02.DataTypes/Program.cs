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



// operators

int sumOfTwoNumbers = 5 + 2;

int num1 = 20000;
int num2 = 20000;

int sumOfNums = num1 + num2;

//short a = 20000;
//short b = 20000;

// short c = a + b;

int a = 1;
a++;
a += 1;

a = a + 1;

bool isValid1 = true;
bool hasPassed1 = false;

isValid1 &= hasPassed1;

isValid1 = isValid1 && hasPassed1;

bool isSame = 5 == 5;
//bool isSame2 = 5 == "5"; // cannot compare different types


// default values

int defaultInt = default; // 0
bool defaultBool = default; // false

char defaultChar = default; // Null character, shows up as nothing ( Not to be confused with null ) 

string defaultString = default; // null
