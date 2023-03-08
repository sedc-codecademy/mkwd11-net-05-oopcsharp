#region STRINGS
// Normal string
string firstName = "Bob";
string lastName = "Bobski";

// Concatanation
string hello1 = "Hello " + firstName + " " + lastName;// Hello Bob Bobski
string hello2 = $"Hello {firstName} {lastName}";
string hello3 = string.Format("Hello {0} {1}",firstName,lastName);

Console.WriteLine(hello1);
Console.WriteLine(hello2);
Console.WriteLine(hello3);

Console.WriteLine("=== Escaping ====");
// Escaping with \ character
string escapingOne = "Check your c:\\ drive";
string escapingTwo = "Check your c \"drive\" ";
// Escaping a whole string with @
string escapingThree = @"Check your c ""drive"" ";
string escapingFour = @"Check your c:\ drive";

Console.WriteLine(escapingThree);

Console.WriteLine("==== Format string ====");

string currency = string.Format(@"This is {0:C}", 125);
Console.WriteLine(currency);

string parcent = string.Format(@"This is {0:P}", 0.05);
Console.WriteLine(parcent);

string number = string.Format(@"This is {0:N}", 24);
Console.WriteLine(number);


#endregion
#region String Method
string stringMethod = " My first string method ";
// Makes our string Upper/Lower Case
string lowerString = stringMethod.ToLower();
string upperString = stringMethod.ToUpper();
Console.WriteLine($"lower: {lowerString}");
Console.WriteLine($"upperString: {upperString}");
// Prints the length of our string
int length = stringMethod.Length;
Console.WriteLine($"Length: {length}");

// Splits the string and makes an array of strings (splits on character selected)
string[] splitString = stringMethod.Split(" ");
Console.WriteLine($"SPLIT: {splitString}");
foreach (string test in splitString)
{
    Console.WriteLine($"SPLIT: {test}");
}
char[] charString = stringMethod.ToCharArray();
foreach (char test in charString)
{
    Console.WriteLine($"ToChar: {test}");
}
// Checks if a string starts with some string given and returns true or false
bool startWith = stringMethod.StartsWith("My");
Console.WriteLine($"startWith: {startWith}");//true

bool startWithH = stringMethod.StartsWith("H");
Console.WriteLine($"startWithH: {startWithH}"); //false

// It trims the white spaces at the front and back of the string
string trimString = stringMethod.Trim();
Console.WriteLine($"trimString: {trimString}");

string replaceString = stringMethod.Replace("first", "second");
Console.WriteLine($"replaceString: {replaceString}");

string substringSring = stringMethod.Substring(5);
string substringSring2 = stringMethod.Substring(1,5);

Console.WriteLine(substringSring);
Console.WriteLine(substringSring2);


string[] number1 = {"one", "two", "three"};

string joindString = string.Join(", ", number1);

Console.WriteLine(joindString);


#endregion

#region Exercise
Console.WriteLine("Enter a number:");
bool numberUser = int.TryParse(Console.ReadLine(), out int numberFromUser);
void Substrings(int number)

{
    string task = "Hello from SEDC Codecacedemy 2022/23";
    if (numberFromUser > task.Length || numberFromUser < 0)
    { Console.WriteLine("You entered wrong number! Pleas enter valid number."); }
    else
    {
        string substringJustForUser = task.Substring(0, number);
        Console.WriteLine(substringJustForUser);
        Console.WriteLine(substringJustForUser.Length);
    }


}
if (numberUser)
{
    Substrings(numberFromUser);
}
else
{
    Console.WriteLine("You enterd wrong character");
}
#endregion