Console.WriteLine("Data Types:");

//===Whole numbers===
int firstIntVariable = 555; //declaration and intitialization
Console.WriteLine("firstIntVariable: " + firstIntVariable);

short firstShortVar = 6;
Console.WriteLine("firstShortVar: " + firstShortVar);


//int firstIntVariable = 44444; Error

//reintitialization
firstIntVariable = 77768;
Console.WriteLine("firstIntVariable: " + firstIntVariable);

//===Decimal numbers===
float firstFloatVar = 1.675f;
Console.WriteLine("firstFloatVar: " + firstFloatVar);
Console.WriteLine(firstFloatVar + 1);

double firstDoubleVar = 2.3456;
Console.WriteLine("firstDoubleVar: " + firstDoubleVar);
Console.WriteLine(firstDoubleVar + 1);


string message = "Hello from SEDC!"; //strings are always in double quotes!!!
Console.WriteLine("message: "+ message);

char firstChar = 'a'; //chars are always written in single quotes!!!
Console.WriteLine("firstChar: " + firstChar);

bool firstBool = true;

int number; //declaration



// Implicitly typed variables take the type of the value that is first given to the variable!!!!
var numberOfStudents = 8;

//numberOfStudents = "Hello";
numberOfStudents = 19;

//numberOfStudents = firstFloatVar / 2;


//===Operators===

int sum = 5 + 90;
Console.WriteLine("sum: " + sum);

sum += 100; // sum = sum + 100;

sum++; //sum  = sum + 1; sum += 1;

Console.WriteLine("sum: " + sum);

int secondSsum = sum;
// You can't take the value from another variable if its not the same type
//string thirdSum = sum;

//===Default values====
int defaultInt; //0
//keyword default sets the default value for the variable's type
defaultInt = default; //0
Console.WriteLine("defaultInt: " + defaultInt);

float deafultFloat = default; //0
Console.WriteLine("deafultFloat: " + deafultFloat);

double defaultDouble = default; //0
Console.WriteLine("defaultDouble: " + defaultDouble);

bool defaultBool = default; //false
Console.WriteLine("defaultBool: " + defaultBool);

string defaultString = default; //null
Console.WriteLine("defaultString: " + defaultString);

string nullString = null;
//Console.WriteLine(nullString.Length); ERROR
string emptyString = "";
Console.WriteLine(emptyString.Length); //0