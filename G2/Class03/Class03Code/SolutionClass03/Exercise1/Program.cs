Console.WriteLine("Enter a number");
// good way to make validation using TryParse
bool success = int.TryParse(Console.ReadLine(), out int counter);
if (success)
{
    for(int i = 1; i <= counter; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Enter another input");
    int anotherCounter = int.Parse(Console.ReadLine());
    for(int i = anotherCounter; i != 0; i--)
    {
        Console.WriteLine(i);
    }
}
