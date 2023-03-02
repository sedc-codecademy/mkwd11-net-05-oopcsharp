//===Conversion===
string numberString = "20";

//int.Parse will fail on any input besides valid int string (any text string, null)
int parsedString = int.Parse(numberString);
Console.WriteLine("parsedString " + parsedString);

string doubleString = "92.5";
double parsedDoubleString = double.Parse(doubleString);
Console.WriteLine("parsedDoubleString " + parsedDoubleString);

//int parsedNumber = int.Parse("text"); ERROR
//Console.WriteLine("parsedNumber " + parsedNumber);

//Convert.ToInt32 will fail on any input besides valid int string or null value (any text string)
//with null value it will return 0 
int number = Convert.ToInt32(numberString);
Console.WriteLine("number " + number);

//int parsedNumberWithConvert = Convert.ToInt32("text"); ERROR
//Console.WriteLine("parsedNumberWithConvert " + parsedNumberWithConvert);

int parsedValue;
//out keyword lets us change the value, assign value to parsedValue variable
bool success = int.TryParse("30", out parsedValue);
Console.WriteLine("parsedValue " + parsedValue);
Console.WriteLine("success " + success);

int secondParsedValue;
//try to parse the value "text" into int, and save the int value in the secondParsedValue variable
//save int secondSuccess whether the parsing was successful
bool secondSuccess = int.TryParse("text", out secondParsedValue);
Console.WriteLine("secondParsedValue " + secondParsedValue);
Console.WriteLine("secondSuccess " + secondSuccess);