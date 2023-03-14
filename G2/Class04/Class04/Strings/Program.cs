// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string name = "Dana";
string company = "Seavus";

//Concatenation
string concatenationexample = "Hello, my name is " + name + " and I work in " + company;
Console.WriteLine(concatenationexample);

//String Interpolation $
string interpolationexample = $"Hello, my name is {name} and I work in {company}";
Console.WriteLine(interpolationexample);

//String Format
//format - format string
//arguments
string formatexample = String.Format("Hello, my name is {0} and I work in {1}", name, company);
Console.WriteLine(formatexample);

//ESCAPING
//string escapingexample = "This is a "string" in C#";   -- not valid
string escapingexample = "This is a \"string\" in C#";
Console.WriteLine(escapingexample);

string escapingexample2 = "This \\n means new line ";
//string escapingexample2 = "This \n means new line ";
//this will move the text in new row
Console.WriteLine(escapingexample2);

//@ Verbatim text
string verbatimexample = @"This is a ""string"" in C#";
Console.WriteLine(verbatimexample);

string verbatimexample2 = @"This \n means new line";
Console.WriteLine(verbatimexample2);