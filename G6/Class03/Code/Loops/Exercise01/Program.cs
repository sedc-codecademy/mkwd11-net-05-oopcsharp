Console.WriteLine("Enter a number:");
int ex1input1 = int.Parse(Console.ReadLine());
for (int i = 1; i <= ex1input1; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Enter another number:");
int ex1input2 = int.Parse(Console.ReadLine());
for (int i = ex1input2; i != 0; i--)
{
    Console.WriteLine(i);
}
Console.ReadLine();