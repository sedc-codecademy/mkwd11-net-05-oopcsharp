//1.Collect the inputs
//Write a console application that will ask the user to
//input 5 different type of inputs. If the user successfully
//add the values, display them in the console,
//else provide him an appropriate message thate he is doing something wrong.

try
{
    Console.WriteLine("Please enter a message");
    string userInputMessage = Console.ReadLine();

    Console.WriteLine("Please enter a number");
    int userInputNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter a character");
    char userInputChar = char.Parse(Console.ReadLine());

    Console.WriteLine("Please enter a decimal number");
    double userInputDecimal = double.Parse(Console.ReadLine());

    Console.WriteLine("Please enter boolean");
    bool userInputBoolean = bool.Parse(Console.ReadLine());


    Console.WriteLine($"You entered message: {userInputMessage}");
    Console.WriteLine($"You entered number: {userInputNumber}");
    Console.WriteLine($"You entered character: {userInputChar}");
    Console.WriteLine($"You entered decimal number: {userInputDecimal}");
    Console.WriteLine($"You entered boolean: {userInputBoolean}");
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You entered a wrong input. Please try again!");
}