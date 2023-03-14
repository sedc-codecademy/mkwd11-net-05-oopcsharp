//Console.WriteLine("Enter first number");
//int firsNum = Convert.ToInt32(Console.ReadLine());
//for(int i = 2; i <= firsNum; i += 2)
//{
//    Console.WriteLine(i + " even number");
//}
//Console.WriteLine("Enter second number");
//int secondNum = Convert.ToInt32(Console.ReadLine());
//for(int i = 1; i <= secondNum; i += 2)
//{
//    Console.WriteLine(i + " odd number");
//}

Console.WriteLine("Enter a number: ");
var userInput = Convert.ToInt32(Console.ReadLine());
for(int i = 2; i <=userInput; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("Enter another number: ");
    var secondUserInput = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= secondUserInput; i++)
{
    if(i % 2 != 0)
        Console.WriteLine(i);
    
}
