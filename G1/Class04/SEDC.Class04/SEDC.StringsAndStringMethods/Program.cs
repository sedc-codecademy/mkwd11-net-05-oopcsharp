

string academyName = "SEDC";
string academy = "Web programming";


// Concatenation
string concatenatedAcademy = academyName + " academy for " + academy;

// String interpolation
string interpolatedAcademy = $"{academyName} academy for {academy}";

// Format() method
string formattedAcademy = string.Format("{0} academy for {1}", academyName, academy);


Console.WriteLine(concatenatedAcademy);
Console.WriteLine(interpolatedAcademy);
Console.WriteLine(formattedAcademy);


// ESCAPING 

Console.WriteLine("Check your c:\\ drive");

Console.WriteLine("We are going to have \"fair\" elections");

Console.WriteLine($"I am going to chechk the c:\\ drive in {academyName}");

Console.WriteLine(@"I am going to ""check"" the c:\ drive");

Console.WriteLine(@$"I am going to ""check"" the c:\ drive in {academyName}");




// FORMAT Strings
string percent = string.Format("This is {0:P}", 0.04);
Console.WriteLine(percent);

string number = string.Format("This is {0:N}", 125000);
Console.WriteLine(number);

string amount = string.Format("{0:C}", 124);
Console.WriteLine(amount);

string phoneNumber = string.Format("{0:0##-###-###}", 078223456);
Console.WriteLine(phoneNumber);


string outString = "We are learning C sharp cus it is cool";
Console.WriteLine(outString.ToUpper());
Console.WriteLine(outString.ToLower());


string[] splittedString = outString.Split(" "); // new string[] {"We", "are", "learning", "C", "sharp"}
for (int i = 0; i < splittedString.Length; i++)
{
    Console.WriteLine(splittedString[i]);
}

int index = Array.IndexOf(splittedString, "learning");
Console.WriteLine(index);


Console.WriteLine(outString.Length);


// SubString()
string subString1 = outString.Substring(3);
Console.WriteLine(subString1);

string subString2 = outString.Substring(0, 5);
Console.WriteLine(subString2);

string message = "     Hello there!!   ";
Console.WriteLine(message.Trim());


#region Class exercise 3 

void Substrings(int numberOfCharacters)
{
    string message = "Hello from SEDC Codecademy 2023";
    string outputString = message.Substring(0, numberOfCharacters);

    Console.WriteLine(@$"The first {numberOfCharacters} characters from the message ""{message}"" are: ""{outputString}"" and its length is {outputString.Length}");
}


while (true)
{
    Console.WriteLine("Please enter number of characters: ");
    bool canParseUserInput = int.TryParse(Console.ReadLine(), out int userInput);
    if(canParseUserInput && userInput > 0)
    {
        Substrings(userInput);
        break;
    }
    else
    {
        continue;
    }
}

#endregion