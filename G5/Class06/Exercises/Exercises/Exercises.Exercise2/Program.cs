#region Methods
void NumberStats(double number)
{
    bool isNegative = number < 0 ? true : false;
    bool isDecimal = number % 1 > 0 ? true : false;
    bool isEven = number % 2 == 0 ? true : false;
    Console.WriteLine($"Stats for number: {number}");
    Console.WriteLine(string.Format("{0}", isNegative ? "Negative" : "Positive"));
    Console.WriteLine(string.Format("{0}", isDecimal ? "Decimal" : "Integer"));
    Console.WriteLine(string.Format("{0}", isEven ? "Even" : "Odd"));
}

bool UserInterface()
{
    Console.Write("Enter a number:");
    double number;
    bool isNumber = double.TryParse(Console.ReadLine(), out number);
    if (!isNumber)
    {
        Console.WriteLine("That was not a number! Please try again!");
        return false;
    }
    NumberStats(number);
    Console.Write("Press any key to try again or X to exit.");
    if (Console.ReadLine().ToUpper() == "X") return true;
    return false;
}
#endregion

while (!UserInterface()) ;
Console.ReadLine();