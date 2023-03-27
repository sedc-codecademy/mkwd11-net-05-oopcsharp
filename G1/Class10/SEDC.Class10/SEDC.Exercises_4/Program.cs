
string HowGoodIsYourNumber(int number)
{
    if (number % 100 == 0)
    {
        return "You have entered a cool number!";
    }
    return "The number you've enterd is not cool at all!";
}

try
{

    Console.WriteLine("Please enter your number:");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine(HowGoodIsYourNumber(number));
}
catch (Exception ex)
{
    Console.WriteLine("Can't you read? Enter a number, not anything else!");
}