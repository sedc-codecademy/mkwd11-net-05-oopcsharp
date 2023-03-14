Console.WriteLine("Please insert a number: ");
bool success = int.TryParse(Console.ReadLine(), out int number);
if (success)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 3 == 0 || i % 7 == 0)
        {
            Console.WriteLine("Skipping...");
            continue;
        }

        if (i == 100)
        {
            Console.WriteLine("You have reached the limit!");
            break;
        }
        Console.WriteLine(i);
    }
}
