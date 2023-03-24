bool FlipTheBooleans(bool userInput)
{
    return !userInput;
}

bool SwapTheBooleans(bool userInput) => !userInput;

try
{
    Console.WriteLine("Please enter a boolean value");
    bool userInput = bool.Parse(Console.ReadLine());

    Console.WriteLine(FlipTheBooleans(userInput));
}
catch (Exception)
{
    Console.WriteLine("Error, incorrect value");
}