// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Declaration
using System.Net.Security;

string name;
name = "Dana";
//Console.WriteLine(name);

//Declaration and inicialization
int num = 1;
char letter = 'D';
bool falsey = false;

float temp = 37.2f;
double temp2 = 37.2d;
decimal temp3 = 37.2m;
//example for presicion for decimal data types

//float f = 10f / 3;
//Console.WriteLine(f);
//double dd = 10d / 3;
//Console.WriteLine(dd);
//decimal dc = 10m / 3;
//Console.WriteLine(dc);

//name = "Anastasija";
//Console.WriteLine(name);

//Console.WriteLine("Hello everybody, my name is " + name);

////Implicit Type Variables
//var varexample = 3;
////Invalid, the variable implicitInt will accept only int values
////varexample = "Dana is blond";

////Artimetic operations:
//int a1 = 5; 
//int b1 = 10;
//int c1 = a1 + b1;
//Console.WriteLine(c1);

////c1 = c1 + 10;
//c1 += 10;
//Console.WriteLine(c1);

////c1 = c1 + 1;
//c1++;
//Console.WriteLine(c1);

////Difference between divide and module
//int d1 = 11;
//int d2 = 4;
//int res1 = d1 / d2;
//int res2 = d1 % d2;
//Console.WriteLine(res1);
//Console.WriteLine(res2);

////Empty string is valid
//string emptystring = "";
//Console.WriteLine(emptystring.Length);

////Exersice 1
//double dd1 = 12.6;
//double dd2 = 4.2;
//double resOfDouble = dd1 / dd2;
//Console.WriteLine(resOfDouble);

//int aa1 = 8;
//int aa2 = 2;
//int resOfInt = aa1 / aa2;
//Console.WriteLine(resOfInt);
//string str1 = "9";
//string str2 = "3";
//string res = str1 + "-" + str2;
//Console.WriteLine(res);

////Exersice 2
//string str3 = "Sime";
//string str4 = "Nokoski";
//string res3 = str3 + str4;
//Console.WriteLine(res3);

////Exersice 3
//str2 = "Dana";
//str4 = "Tasevska";
//int aa = 10;
//string str5 = str2 + str4 + aa;
//Console.WriteLine(str5);

////Exersice 4
//int m = 102;
//int n = 5;
//int messages = m / n;
//int creditLeft = m % n;
//Console.WriteLine(messages);
//Console.WriteLine(creditLeft);

//Data entry
//From console we always get string
//Console.WriteLine("What is your name?");
//name = Console.ReadLine();
//Console.WriteLine("Hello, nice to meet you " + name + "!");
//Console.WriteLine("How old are you?");
////var age = Console.ReadLine();
//var age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Thank you for the info for your age " + age);
//Console.WriteLine(age.GetType());

////Convert with Parse
//string numString = "9";
//string doubleString = "2.5";

//int parseInt = int.Parse(numString);
//double parseDouble = double.Parse(doubleString);

//Console.WriteLine(parseInt);
//Console.WriteLine(parseInt.GetType());

////Convert with Convert

//int convertInt = Convert.ToInt32(numString);
//double convertDouble = Convert.ToDouble(doubleString);

////Convert with TryParse
//int tryparseconvert;
//string exampletryparse = "12";
//bool successtryparse = int.TryParse(exampletryparse, out tryparseconvert);
//Console.WriteLine(successtryparse);
//Console.WriteLine(tryparseconvert);

//IF/ELSE block

//if (5 > 3)
//{
//    Console.WriteLine("5 is bigger then 3");
//}

//else 
//{
//    Console.WriteLine("5 is not bigger then 3");
//}

//Console.WriteLine("Please enter one number");
//var input1 = Convert.ToInt32(Console.ReadLine());

//if (input1 > 0)
//{
//    Console.WriteLine("You entered positive number");
//}

//else if (input1 < 0)
//{
//    Console.WriteLine("You entered negative number");
//}

//else if (input1 == 0)
//{
//    Console.WriteLine("You entered zero");
//}

//else {
//    Console.WriteLine("You entered invalid number");
//}

////Exercise 5
//Console.WriteLine("Input the number of trees.");
//var trees = Convert.ToInt32(Console.ReadLine());
//int applesOnABranch = 8;
//int applesInABasket = 5;
//int basketsNeeded = (trees * (12 * applesOnABranch)) / applesInABasket;
//Console.WriteLine(" For " + trees + " trees, you will need " + basketsNeeded + " baskets. ");

var input1 = Convert.ToInt32(Console.ReadLine());
var input2 = Convert.ToInt32(Console.ReadLine());
if(input1 == input2)
{
    Console.WriteLine("The numbers are equal");
}
else if(input1 > input2)
{
    Console.WriteLine("Input 1 is greater than input 2");
}
else
{
    Console.WriteLine("Input 2 is greater than input 1");
}
if(input1 % 2 == 0)
{
    Console.WriteLine("Input 1 is even");
}
else
{
    Console.WriteLine("Input 1 is odd");
}
if(input2 % 2 == 0)
{
    Console.WriteLine("Input 2 is even");
}
else
{
    Console.WriteLine("Input 2 is odd");
}
