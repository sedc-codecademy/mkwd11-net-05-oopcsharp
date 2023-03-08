string message = "We are learning about strings";

string academy = "SEDC";

//Concatenation
string firstMessage = "Welcome to " + academy;
Console.WriteLine(firstMessage);
string secondMessage = $"Welcome to {academy}";
int year = 2023;
string thirdMessage = $"We are students at {academy}, in {year} year";
Console.WriteLine(thirdMessage);
//formatting strings
string fourthMessage = string.Format("Welcome to {0} in {1}", academy, year);
Console.WriteLine(fourthMessage);

//Escape
string firstString = "Check your c:\\drive";
Console.WriteLine(firstString);

string secondString = "We have \"fair\" elections";
Console.WriteLine(secondString);

//new line
string stringWithNewLine = "This is first line. \n This is the secons line";
Console.WriteLine(stringWithNewLine);

string drivesMessage = @"Check your c:\ drive and D:\ drive";
Console.WriteLine(drivesMessage);

string quotesString = @"These are ""fair"" elections";
Console.WriteLine(quotesString);

//String formatting
Console.WriteLine("=== string formatting===");
string currencyString = string.Format("This costs {0:C}", 150);
Console.WriteLine(currencyString);

string percentString = string.Format("{0:P} participated in the elections", 0.5);
Console.WriteLine(percentString);

string phoneNumber = string.Format("{0:+389##-###-###}", 70123456);
Console.WriteLine(phoneNumber);

Console.WriteLine("=== string methods ====");
string ourString = "   We are learning C# and it is FUN and EASY. Okay maybe just FUN.    ";

string lowerCaseString = ourString.ToLower(); //all characters to lower case
string upperCaseString = ourString.ToUpper(); //all characters to upper case

Console.WriteLine($"ourString: {ourString}");
Console.WriteLine($"lowerCaseString: {lowerCaseString}");
Console.WriteLine($"upperCaseString: {upperCaseString}");

//Length
Console.WriteLine($"The length of our string is: {ourString.Length}");
string[] splittedStrings = ourString.Split('.');
Console.WriteLine(splittedStrings.Length);
Console.WriteLine(splittedStrings[0]);
Console.WriteLine(splittedStrings[1]);
Console.WriteLine(splittedStrings[2]);

string test = "Test";
bool startsWithTe = test.StartsWith("Te");
Console.WriteLine(startsWithTe);

int indexOfFun = ourString.IndexOf("FUN"); //returns the index of the first occurence of FUN
int indexOfJS = ourString.IndexOf("JS"); //returns -1

bool containsFun = ourString.Contains("FUN"); //returns true or false, whether FUN is found anywhere in ourString

//from ourString take the substring starting from index 5 and next 16 characters
string substring = ourString.Substring(5, 16);
Console.WriteLine(substring);

Console.WriteLine(ourString.Substring(5, 16).IndexOf("C#"));

//"     test@email.com" != "test@email.com"

//eliminate empty spaces at the beginning and at the end
string trimmedString = ourString.Trim();
Console.WriteLine($"ourString: {ourString}");
Console.WriteLine($"trimmedString: {trimmedString}");

//ourString.TrimStart();
//ourString.TrimEnd();




string[] words = "We are learning C# at SEDC".Split(" ");

char[] chars = ourString.ToCharArray();

Console.WriteLine();