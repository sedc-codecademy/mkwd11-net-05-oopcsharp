// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

string name = "Bob";

string greet = "Hello " + name;
Console.WriteLine(greet);
// "{0} {1} {2}"
string greet1 = string.Format("Hello {0}", name);
Console.WriteLine(greet1);
string name1 = "Trajan";
string name2 = "Dragan";
string greet2 = string.Format(
    "Hello to {0}, {1}, {2}", "Trajan", "Dragan", name);
string greet3 = string.Format(
    "Hello to {0}, {1}, {2}", name1, name2, name);

Console.WriteLine(greet2);
Console.WriteLine(greet3);

string str = string.Format("This is {0:P}", 0.5);
Console.WriteLine(str);

string greet4 = $"Hello {name}";
Console.WriteLine(greet4);

string a = "Check your c:\\ drive";
string b = "We will have \"fair\" elections";
string c = "The \\n sign meands: new line";

string aa = @"Check your c:\ drive";
string bb = @"We will have ""fair"" elections";
string cc = @"The \n sign meands: new line";

string folder = "git";
string f = $@"c:\{folder}\";


string str1 = string.Format("{0:+###(##)-###-###}", 38975555555);
Console.WriteLine(str1);

string str2 = string.Format("{0:C}", 100);
Console.WriteLine(str2);

string myCustomString = string.Format("| {0,10} | {1,10}|", "Id", "Order");
string myCustomString1 = string.Format("| {0,10} | {1,10}|", 25, "A box");
Console.WriteLine(myCustomString);
Console.WriteLine(myCustomString1);


// string methods

string ourString = 
    "   We are learning C# and it is FUN and EASY. Okay maybe just FUN.    ";
Console.WriteLine(ourString);

string trimedStr = ourString.Trim();
Console.WriteLine(trimedStr);

string lower = ourString.ToLower();
Console.WriteLine(lower);
string upper = ourString.ToUpper();
Console.WriteLine(upper);

int ourLength = ourString.Length;
Console.WriteLine(ourLength);

string[] splited = ourString.Split('.');
foreach(string s in splited)
{
    Console.WriteLine(s);
}

bool startsWith = ourString.StartsWith("   W");
// ourString.EndsWith(); // ends with
// ourString.Contains(); // contains given string

int indexOfString = ourString.IndexOf("FUN");
Console.WriteLine(indexOfString);

char[] chars =  ourString.ToCharArray();
foreach(char s in chars)
{
    Console.WriteLine(s);
}

string substring = ourString.Substring(0, indexOfString);
string substring1 = ourString.Substring(indexOfString, 3);
Console.WriteLine(substring);
Console.WriteLine(substring1);

bool IsNullOrEmpty = string.IsNullOrEmpty(ourString); // null, empty string
bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(ourString); // null, empty string, string with white spaces