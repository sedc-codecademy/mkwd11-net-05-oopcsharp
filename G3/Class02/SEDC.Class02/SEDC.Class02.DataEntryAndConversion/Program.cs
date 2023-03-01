// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Console.WriteLine("Please enter your name");

//string name = Console.ReadLine();

//Console.WriteLine("Hello there " + name);

string number = Console.ReadLine();

// int parseInt = int.Parse(number);

//Console.WriteLine(parseInt);
//string notValidString = default;
//double parseDouble = Convert.ToDouble(notValidString);
//Console.WriteLine(parseDouble);

//double parsedDouble = Convert.ToDouble(number);

//Console.WriteLine(parsedDouble);

int parsedInteger = 0;
bool isValidParsing = int.TryParse(number, out parsedInteger);

Console.WriteLine(isValidParsing);
Console.WriteLine(parsedInteger);

bool isValidNumber = int.TryParse(number, out int value);

Console.WriteLine(isValidNumber);
Console.WriteLine(value);