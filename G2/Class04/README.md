Class 04 - Methods, Strings, and DateTime 😎
Methods
Methods in C# are basic functions. They are called methods because everything we do in C# is contained in some classes ( More on this in later classes ). The benefits of functions and methods are universal, so as in other languages, in C# methods are very useful for organizing the code, reusing, and decoupling code. The difference is strictly typed languages is that methods require a bit more oversight before writing them. When writing a C# method, there needs to be a data type of the return value provided, a name, and a data type of the parameters provided as well. So everything has a data type, even the return ( we have to calculate what we will return at the end ). If we don't want to return anything we can just write void, meaning that the function returns nothing. This is how a method in a console application is written:

// The type before the name is the return type
// public and static will be discussed in next classes
public  string SayHello(string name){
  string result = $"Hello there {name}!";
  return result;
}
// Void function that does not return anything
public  void SayBye(){
  Console.WriteLine("Byeeeee!");
}
Strings
Working with strings in C# can be done in different shapes and forms. There is only one way to write a string and that is with " " but there are multiple ways they can be formatted. This can be done by:

String building
string hello1 = "Hello " + name;
string hello2 = string.Format("Hello {0}", name);
string hello3 = $"Hello {name}";
String formating
// Currency formating
string currency = string.Format("{0:C}", 125.45); 
// Percent formating
string percent = string.Format("{0:P}", .5); 
// Custom formating
string customFormat = string.Format("{0:0##-###-###}", 078270396); 
// Alignment formatting
string customAlignment = string.Format("| {0,10} | {1,10} |", "Id", "Order"); 
Escaping strings
// Escaping with \ character
string a = "Check your c:\\ drive";
string b = "We will have \"fair\" elections";
string c = "The \\n sign means: new line";

// Escaping a whole string with @
string aa = @"Check your c:\ drive";
string bb = @"We will have ""fair"" elections";
string cc = @"The \n sign means: new line";
String methods
string ourString = "   We are learning C# and it is FUN and EASY. Okay, maybe just FUN.    ";
Console.WriteLine(ourString);

// Makes our string Upper/Lower Case
string lowe = ourString.ToLower();
Console.WriteLine(lowe);
string upper = ourString.ToUpper();
Console.WriteLine(upper);

// Prints the length of our string
int ourLength = ourString.Length;
Console.WriteLine(ourLength);

// Splits the string and makes an array of strings (splits on character selected)
string[] splited = ourString.Split('.');
Console.WriteLine(splited[0]);
Console.WriteLine(splited[1]);
Console.WriteLine(splited[2]);
// The line below is commented because there is no index 3 in our splited array
//Console.WriteLine(splited[3]);

// Checks if a string starts with some string given and returns true or false
bool startsWith = ourString.StartsWith("   W");
Console.WriteLine(startsWith);

// Checks if a string exists and if so returns an index, if not -1
int indexOfString = ourString.IndexOf("FUN");
int nonExistingString = ourString.IndexOf("Nope");
Console.WriteLine(indexOfString);
Console.WriteLine(nonExistingString);

// Cuts the string in to a substring that starts from index 5 and takes the next 16 characters
string substring = ourString.Substring(5, 16);
Console.WriteLine(substring);

// Creates an array of characters with every character from our string
char[] chars = ourString.ToCharArray();
Console.WriteLine(chars.Length);
Console.WriteLine(chars[6]);
// Two ways to turn char[] back to string
Console.WriteLine(string.Join("", chars));
Console.WriteLine(new string(chars));

// It trims the white spaces at the front and back of the string
string trimmedString = ourString.Trim();
Console.WriteLine(trimmedString);
DateTime
DateTime is a complex type in C# representing the date and the time at a particular moment. This complex type can be edited, manipulated, and used every time we need to store dates or time and change or use it easily.

Creating DateTime
DateTime aDate = new DateTime(); // Creating a new empty date
DateTime aCustomDate = new DateTime(1992, 10, 15); // Creating a custom date
DateTime currentDay = DateTime.Today; // Getting todays date without time
DateTime currentDateTime = DateTime.Now; // Getting todays date with time
Converting and formating a string
string dateFormat1 = DateTime.Now.ToString("MM/dd/yyyy"); // Formating date to string
string dateFormat2 = DateTime.Now.ToString("dddd, dd MMMM yyyy"); // Formating date to string
string stringDate = "12-15-2012"; 
DateTime convertedDate = DateTime.Parse(stringDate); // Converting string to date
Manipulating DateTime
DateTime  currentDateTime  =  DateTime.Now;

// Adding or removing days to a DateTime date
DateTime addedDays = currentDateTime.AddDays(2);
Console.WriteLine(addedDays);
DateTime removedDays = currentDateTime.AddDays(-5);
Console.WriteLine(removedDays);

// Adding months to a DateTime date
DateTime addedMonths = currentDateTime.AddMonths(2);
Console.WriteLine(addedMonths);

// Adding years to a DateTime date
DateTime addedYears = currentDateTime.AddYears(2);
Console.WriteLine(addedYears);

// Adding hours to a DateTime date
DateTime addedHours = currentDateTime.AddHours(3);
Console.WriteLine(addedHours);

// Get the number of the month from a DateTime
int month = currentDateTime.Month;
Console.WriteLine(month);

// Get the number of the day from a DateTime
int day = currentDateTime.Day;
Console.WriteLine(day);

// Get the number of the year from a DateTime
int year = currentDateTime.Year;
Console.WriteLine(year);