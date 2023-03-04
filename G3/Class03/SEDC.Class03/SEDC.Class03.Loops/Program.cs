// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region For loop
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// Infinite for loop
//for (; ; )
//{
//    Console.WriteLine("This will go on forever!");
//}

// Loops indefinetly unless a condition in the block is met
//for(; ; )
//{
//    Console.WriteLine("This will go on forever unless you enter x!");
//    string input = Console.ReadLine();

//    if(input == "x" || input == "X")
//    {
//        break;
//    }
//}

Console.WriteLine("Creating a droid army: ");
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Assembling Droid batalion " + i);
    if(i == 5)
    {
        Console.WriteLine("Problem in assembling with droid batalion " + i);
        continue;
    }
    if(i == 7)
    {
        Console.WriteLine("Droid assembler broke down!");
        break;
    }
    Console.WriteLine("Droid batalion " + i + " is operational.");
}

#endregion

#region While loop

int index = 0;
while(index < 10)
{
    Console.WriteLine(index);
    index++;
}


// infinite while
//while(true)
//{
//    Console.WriteLine("This will go on forever unless you enter X!");
//    string input = Console.ReadLine();
//    if (input == "X" || input == "x") 
//    {
//        break; 
//    }
//}

#endregion

#region Do-While

int doWhileCounter = 0;
do
{
    Console.WriteLine(doWhileCounter);
    doWhileCounter++;
} 
while(doWhileCounter < 10);

do
{
    Console.WriteLine("This will be executed once!");
}
while (false);

#endregion