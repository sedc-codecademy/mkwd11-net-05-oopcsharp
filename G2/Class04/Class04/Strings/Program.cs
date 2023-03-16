// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string name = "Dana";
string company = "Seavus";

////Concatenation
//string concatenationexample = "Hello, my name is " + name + " and I work in " + company;
//Console.WriteLine(concatenationexample);

////String Interpolation $
//string interpolationexample = $"Hello, my name is {name} and I work in {company}";
//Console.WriteLine(interpolationexample);

////String Format
////format - format string
////arguments
//string formatexample = String.Format("Hello, my name is {0} and I work in {1}", name, company);
//Console.WriteLine(formatexample);

////ESCAPING
////string escapingexample = "This is a "string" in C#";   -- not valid
//string escapingexample = "This is a \"string\" in C#";
//Console.WriteLine(escapingexample);

//string escapingexample2 = "This \\n means new line ";
////string escapingexample2 = "This \n means new line ";
////this will move the text in new row
//Console.WriteLine(escapingexample2);

////@ Verbatim text
//string verbatimexample = @"This is a ""string"" in C#";
//Console.WriteLine(verbatimexample);

//string verbatimexample2 = @"This \n means new line";
//Console.WriteLine(verbatimexample2);

string verbatimexample3 = @$"I am going to ""check"" the c:\drive in {company}";
Console.WriteLine(verbatimexample3);

//STRING FORMAT Examples
//percentage
string percentageexample = String.Format("This is {0:P}", 0.5);
Console.WriteLine(percentageexample);

//Number
string numberexample = String.Format("This is {0:N}", 125000);
Console.WriteLine(numberexample);

//two decimal spaces
string decimalspaceexample = String.Format("Two decimal places {0:0.00}", 125.265);
Console.WriteLine(decimalspaceexample);

//Custom format
string customexample = String.Format("{0:0##/###-###}", 070775944);
Console.WriteLine(customexample);

//Lower/Upper
string s = " Sometimes you win, sometimes you lose ";
string upperexample = s.ToUpper();
Console.WriteLine(upperexample);
//The same is with ToLower()

//Trim - removes empty space from the back and the front of the string
string trimexapmle = s.Trim();
Console.WriteLine(trimexapmle);

//Length - number of charachters in the string
int lenghtexample = s.Length;
Console.WriteLine(lenghtexample);

//Starts with - checks if the string starts with specific charachter or not
string s1 = "Enjoy your day";
bool startswith = s1.StartsWith("z");
Console.WriteLine(startswith);
//You can also use EndsWith()

//IndexOf - returns the first occurance of the specific charachter
//the second paramether in the method is giving the star position from where to check
//if the charachter is not found it returns -1
int indexofexample = name.IndexOf("Y",2);
Console.WriteLine(name);
Console.WriteLine(indexofexample);

//Substring
string substringexample = s1.Substring(2, 2);
Console.WriteLine(s1);
Console.WriteLine(substringexample);

//Split
//string splitexamle = "C#:is::fun:programming:language";
string splitexample = "C# is fun programming language";
string[] splitstring = splitexample.Split("m");

foreach (string splits in splitstring)
{ 
   Console.WriteLine(splits);
}

//ToCharArray()
string charaarrayexample = "L anguage";
char[] charss = charaarrayexample.ToCharArray();

foreach (char c in charss)
{ 
    Console.WriteLine(c);
}



void Substring()
{
    string newString = "Hello from SEDC Codeacademy 2023";
    Console.WriteLine("Input a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int lengthOfString = newString.Length;
    string newSubstring = newString.Substring(n, lengthOfString - n);
    Console.WriteLine($@"The new string is ""{newSubstring}"", the length of the original string is {lengthOfString}");

        }
Substring();