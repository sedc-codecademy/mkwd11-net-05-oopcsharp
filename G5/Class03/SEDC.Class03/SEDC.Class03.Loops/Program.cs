#region For Loop


Console.WriteLine("=== For Loop ===");
// Classic for loop
/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
*/

// Inifinite for loops
/*
for (; ; )
{
    Console.WriteLine("This will go forever unless your enter 'X'!");
    string input = Console.ReadLine();
    if (input == "X" || input == "x")
    {
        break;
    }
}


for (; ; )
{
    Console.WriteLine("Please enter a number > ");
    bool isUserInputParsed = int.TryParse(Console.ReadLine(), out int parsedUserInput);
    if (isUserInputParsed)
    {
        Console.WriteLine(parsedUserInput);
        break;
    }

    Console.WriteLine("Invalid Input!");
}
*/


// continue & break
/*
for (int i = 0; i < 10; i++)
{
    if (i == 3 || i == 5)
        continue;

    if (i == 4)
        break;

    Console.WriteLine($"Iteration No. {i}");
}
*/

#endregion

#region While Loop

int whileIterator = 0;
// Classic while loop
/*
while (whileIterator <= 10)
{
    Console.WriteLine($"[{whileIterator}] Looping...");
    whileIterator++;
}
*/

// Infinite while loop
/*
while (true)
{
    Console.Write("Please enter a number: ");
    bool isUserInputParsed = int.TryParse(Console.ReadLine(), out int parsedUserInput);

    if (isUserInputParsed)
    {
        Console.WriteLine($"Parsed! {parsedUserInput}");
        break;
    }

    Console.WriteLine("You entered a invalid input!");
}
*/

// continue & break
/*
while (whileIterator <= 10)
{
    if (whileIterator == 3 || whileIterator == 5)
    {
        whileIterator++;
        continue;
    }

    if (whileIterator == 4)
        break;

    Console.WriteLine($"Iteration No. {whileIterator}");
    whileIterator++;
}
*/


//While &  Do While
// Do while executes the code in 'do' at least once

/*
Console.WriteLine("Do While");
do
{
    Console.WriteLine(whileIterator);
} while (whileIterator < 0);

Console.WriteLine("Please press any key to continue...");
Console.ReadKey(); // Waits for a keypress

Console.WriteLine("While");
while (whileIterator < 0)
{
    Console.WriteLine(whileIterator);
}
*/
#endregion