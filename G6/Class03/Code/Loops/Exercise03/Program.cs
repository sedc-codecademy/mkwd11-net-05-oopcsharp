Console.WriteLine("Enter a number:");
int input = int.Parse(Console.ReadLine());
for (int i = 1; i <= input; i++)
{
    if (i % 3 == 0 || i % 7 == 0) 
        continue;
    if (i == 100)
    {
        Console.WriteLine("The limit is reached!");
        break;
    }
    Console.WriteLine(i);
}