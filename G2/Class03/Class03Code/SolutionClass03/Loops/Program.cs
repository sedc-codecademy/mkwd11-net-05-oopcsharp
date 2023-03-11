//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("===For loop===");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//for(; ; )
//{
//    Console.WriteLine("Hello");
//}

for(; ; )
{
    Console.WriteLine("Enter input");
    string input = Console.ReadLine();

    //if (input == "X" || input == "x")
    if(input.ToLower() == "x")
    {
        break;
    }
}

for(int i = 0; i < 10; i++)
{
    if(i == 5)
    {
        Console.WriteLine("Breaking...");
        break;
    }

    if(i == 3)
    {
        Console.WriteLine("Skipping...");
        continue;
    }
}

Console.WriteLine("===while===");

int counter = 0;

while(counter <= 10)
{
    Console.WriteLine(counter);
    counter++;
}

while (true)
{
    Console.WriteLine("Enter inpup");
    string input = Console.ReadLine();

    if(input.ToLower() == "yes")
    {
        break;
    }
}

int anotherCounter = 0;
while(anotherCounter <= 10)
{
    if (anotherCounter == 3)
    {
        Console.WriteLine("Skipping in while...");
        anotherCounter++;
        continue;
    }
    if (anotherCounter == 5)
    {
        Console.WriteLine("Breaking in while..");
        break;
    }
    Console.WriteLine(anotherCounter);
    anotherCounter++;
}

Console.WriteLine("===Do while");
int thirdCounter = 0;
do
{
    Console.WriteLine(thirdCounter);
    thirdCounter++;
}
while(thirdCounter <= 3);

do
{
    Console.WriteLine("This message will be written!");
}
while (false);
