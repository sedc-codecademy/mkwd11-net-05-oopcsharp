using Enums.Enums;

void IsParty(Days day)
{
    if(day == Days.Saturday)
    {
        Console.WriteLine("PARTYY");
    }
    else
    {
        Console.WriteLine("No party");
    }
}

// Enumeration in a variable
Days saturday = Days.Saturday;

// Get a number from an enum
int integer = (int)saturday; // 6
Console.WriteLine(integer);
Console.WriteLine(saturday.GetTypeCode()); // Int.32

// Using enum in a method
IsParty(saturday);// PARTYYYYY
IsParty(Days.Friday);// No party

// Enumeration in a variable
Days monday = Days.Monday;

string stringMonday = monday.ToString();//Monday
Console.WriteLine(stringMonday.GetTypeCode()); //String

