
string NumberStats(string number)
{
    bool isPositive = false;
    bool isInteger = false;
    bool isEven = false;

    string result = "";

    bool canBeParsed = int.TryParse(number, out int num);

    if (canBeParsed)
    {
        isInteger = true;
    }

    if (num > 0)
    {
        isPositive = true;
    }

    if (num % 2 == 0)
    {
        isEven = true;
    }

    if (isInteger)
    {
        result += "The number is integer ";
    }
    else
    {
        result += "The number is decimal ";
    }

    if (isPositive)
    {
        result += " and the number is positive ";
    }
    else
    {
        result += " and the number is negative ";
    }

    if (isEven)
    {
        result += " and the number is even ";
    }
    else
    {
        result += " and the number is odd ";
    }

    return result;
}



Console.WriteLine(NumberStats("25.4"));