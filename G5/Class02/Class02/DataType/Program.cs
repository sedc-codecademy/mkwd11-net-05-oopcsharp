Console.WriteLine("==== INTEGER====");

int number; //declaration (int variable)
number = 12; // initialization

int age = 25; //declaration and initialization 
/*num = "Hey";*/ // This will be marked as an error

Console.WriteLine(age); //Value of variable age
Console.WriteLine(number); //Value of variable age
Console.WriteLine(number.GetType()); // We get the type with the method GetType() (Data type of age).
Console.WriteLine(number.GetType());  //Find out what type some variable is (Data type of number)
Console.WriteLine(number.GetTypeCode()); //Find out what type some variable is. Without System (Data type of number)


Console.WriteLine("==== FLOAT ====");
float decimalNumber = 1.2F; // float variable
Console.WriteLine(decimalNumber); //Value of variable decimalNumber
Console.WriteLine(decimalNumber.GetTypeCode());

Console.WriteLine("=== Char ===");
char charVariable = 'A';
Console.WriteLine(charVariable); //Value of variable charVariable
Console.WriteLine(charVariable.GetTypeCode());

Console.WriteLine("=== String ===");
string stringVariable = "Hello SEDC"; //string variable
Console.WriteLine(stringVariable);
Console.WriteLine(stringVariable.GetTypeCode());

Console.WriteLine("=== Boolean === ");
bool boolVariable = false; //boolean variable
Console.WriteLine(boolVariable); // Value of variable boolVariable
Console.WriteLine(boolVariable.GetTypeCode());

bool isLarger = 62 > 112;
Console.WriteLine(isLarger); // false

Console.WriteLine("==== Double ====");
double doubleVariable = 0.2; //double variable
Console.WriteLine(doubleVariable);
Console.WriteLine(doubleVariable.GetTypeCode());

Console.WriteLine("=== DateTime ===");

DateTime currentTime = DateTime.Now;

Console.WriteLine(currentTime);
Console.WriteLine(currentTime.GetTypeCode());

Console.WriteLine("==== Default ====");

Console.WriteLine("==== Double default ===");
double doubleVariableDefault = default; //default value of double,long, short, int and float is 0
Console.WriteLine(doubleVariableDefault);// 0

Console.WriteLine("==== Boolean default ===");
bool defaultBool = default; //default value of bool is false
Console.WriteLine(defaultBool); //false

Console.WriteLine("==== String default ===");
string stringVariableDefault = default; //default value of string, char is null
Console.WriteLine(stringVariableDefault);// null

string nullString = null;
Console.WriteLine(nullString); // Null 

// Null vs Empty String

string emptyString = "";
// Empty string is still a string and we can work with it as a string with all methods
Console.WriteLine(emptyString.Length); // Will return 0 because the length of the string is 0 characters

// Null is empty, meaning there is nothing there. Unlike the empty string, null is not a string
// Console.WriteLine(nullString.Length); // Will throw null reference exception since there is no string there


Console.WriteLine("==== Operations ===");

Console.WriteLine("==== Sum ===");
int a = 12;
int b = 12;

int sum = a + b; // sum a and b. Value save in variable sum.
Console.WriteLine(sum); // 24


Console.WriteLine("==== Error ===");

int numberError = 2;

//number = 2.2; //This error is because we want to change the value to a double

// Implicitly typed variables take the typ of the value
var changeVariable = 5;

// The type can't be chagned later, like in JavaScript
//changeVariable = "Miki";


Console.WriteLine("==== Exercise ===");

Console.WriteLine("==== Exercise 01 ===");

// Exercise 1
int numberOne; // declaration
numberOne = 4; // initialization
int numberTwo;
numberTwo = 12;
int resultOfNumber = numberOne / numberTwo;
Console.WriteLine("Result of integer:" + resultOfNumber);

double doubleNumOne = 4;
double doubleNumTwo = 12;
double resultOfDouble = doubleNumOne / doubleNumTwo;
Console.WriteLine("Result of double:" + resultOfDouble);
Console.ReadLine();

Console.WriteLine("==== Exercise 02 ===");
// Exercise 2
string firstName = "FirstName";
string lastName = "LastName";
string fullName = firstName + " " + lastName; // Adding empty space to divide the strings
Console.WriteLine("FullName:" + fullName);

string stringNumOne = "5";
string stringNumTwo = "7";
string stringNumResult = stringNumOne + stringNumTwo;
Console.WriteLine("Exercise 2 numbers Result:" + stringNumResult);
Console.ReadLine();

Console.WriteLine("==== Exercise 03 ===");
// Exercise 3
int integerNumber = 9;
string code = "Code";
string resultStringAndNumber = integerNumber + code;
Console.WriteLine("Exercise 3 Result:" + resultStringAndNumber);
Console.ReadLine();

Console.WriteLine("==== Exercise 04 ===");
// Exercise 4
int credit = 102;
int messageCost = 5;
int messagesSent = credit / messageCost;
Console.WriteLine($"You can send: {messagesSent} messages!"); // string interpolation
Console.WriteLine("You can send: " + messagesSent + " messages!");
Console.ReadLine();
