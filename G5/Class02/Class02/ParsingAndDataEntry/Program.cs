Console.WriteLine("=== Data Entry====");

Console.Write("Enter fist name: ");
string firstName = Console.ReadLine(); // ReadLine waits for a user input and adds that value in to the variable
Console.WriteLine(firstName);
Console.WriteLine(firstName.GetTypeCode());
Console.Write("Enter last name: ");
string lastName = Console.ReadLine();// ReadLine waits for a user input and adds that value in to the variable
Console.WriteLine(lastName);

Console.WriteLine("AGE: " + Console.ReadLine());


Console.ReadLine();


Console.WriteLine("==== Parsing =====");

Console.WriteLine("==== 1.Type.Parse(value) =====");
string numberStringInteger = "2";
string numberStringDouble = "3.2";
int numberInteger = int.Parse(numberStringInteger);
//int number1 = int.Parse(numberString2); //There is an error here because we are trying to convert it to an integer
double numberDouble = double.Parse(numberStringDouble);

Console.WriteLine("=== Result of parse in integer===");
Console.WriteLine(numberInteger);
Console.WriteLine(numberInteger.GetTypeCode());
Console.WriteLine("=== Result of parse in double===");
Console.WriteLine(numberDouble);
Console.WriteLine(numberDouble.GetTypeCode());

Console.Write("==== Parse DateTime === ");

string dateTimeString = "2022-02-28 12:34:56";
DateTime parsedDateTime = DateTime.Parse(dateTimeString);

Console.WriteLine("Parsed DateTime: " + parsedDateTime.ToString());
Console.WriteLine("Type: " + parsedDateTime.GetTypeCode());
Console.ReadLine();


Console.WriteLine("==== 2.Convert.ToType(value) =====");
string numberStringToInt = "40";
string numberString2ToDouble = "21.3";

int parseInt = Convert.ToInt32(numberStringToInt);
double parseDouble = Convert.ToDouble(numberString2ToDouble);

Console.WriteLine("=== Result of parse in integer==="); 
Console.WriteLine(parseInt);
Console.WriteLine(parseInt.GetTypeCode());
Console.WriteLine("=== Result of parse in double===");
Console.WriteLine(parseDouble);
Console.WriteLine(parseDouble.GetTypeCode());
Console.ReadLine();

Console.WriteLine("==== 3.type.TryParse(value, out type variables) =====");


//int ifParsedValue; //You can declare it here and use it in TryParse // if try parse succseeds we will put the converted value here
// We create a boolean variable that will keep info if the parsing was done or not
//string numberParse = "221.123";
//bool stringSucc = double.TryParse(numberParse, out ifParsedValue);

string numberParse = "221.123";
bool stringSucc = double.TryParse(numberParse, out double ifParsedValue);

Console.WriteLine("=== Result of parse in double ===");
Console.WriteLine(stringSucc); //true
Console.WriteLine(ifParsedValue); // 221.123
Console.WriteLine(ifParsedValue.GetTypeCode());//double
Console.ReadLine();

// Getting a value from a user and parsing it
Console.Write("Enter number: ");
var enterNumber = int.Parse(Console.ReadLine());
Console.WriteLine(enterNumber);
Console.WriteLine(enterNumber.GetTypeCode());
Console.ReadLine();

