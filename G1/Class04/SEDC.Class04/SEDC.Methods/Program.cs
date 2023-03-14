

// Method that print in the console
// and has no return type nor input parameters
void SayHello()
{
    Console.WriteLine("Hello there!");
}


// Method that returns nothing but accept
// one input parameter of type string
void SayGoodbye(string name)
{
    Console.WriteLine("Bye bye " + name);
}


void StoryTeller(string who, string when, string where)
{
    Console.WriteLine("There was a king called " + who +
                      ". He lived " + when +
                      " in " + where);
}


bool IsRaining()
{
    return true;
}


string TellMeTheDay(int number)
{
    switch (number)
    {
        case 1:
            return "Monday";
        case 2:
            return "Tuesday";
        case 3:
            return "Wednesday";
        case 4:
            return "Thursday";
        case 5:
            return "Friday";
        case 6:
            return "Saturday";
        case 7:
            return "Sunday";
        default:
            return "There is no such day!";
    }
}


SayHello();
SayGoodbye("Marija");
SayGoodbye("Martin");
SayGoodbye("Mihail");
StoryTeller("Martin", "1000 years ago", "the kingdom of far far away");


IsRaining();


Console.WriteLine(TellMeTheDay(3));

string day = TellMeTheDay(4);
Console.WriteLine(day);



#region Class exercise 1

int Sum(int first, int second)
{
    return first + second;
}

int Subtract(int first, int second)
{
    return first - second;
}



Console.WriteLine("Please enter number 1:");
bool canParseFirst = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Please enter number 2:");
bool canParseSecond = int.TryParse(Console.ReadLine(), out int secondNumber);

Console.WriteLine("Please enter sign + or -");
string operation = Console.ReadLine();


if(canParseFirst && canParseSecond)
{
    if (operation == "+")
    {
        Console.WriteLine(Sum(firstNumber, secondNumber));
    }
    else if (operation == "-")
    {
        Console.WriteLine(Subtract(firstNumber, secondNumber));
    }
}
else
{
    Console.WriteLine("Ooops!!! Something went wrong!");
}
#endregion