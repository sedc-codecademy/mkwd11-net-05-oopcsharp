


#region For loop, break, continue

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Hello " + i);
//}



// Empty for in C# but also INFINITE LOOP!!!
//for (; ; )
//{

//}

// Use infinite for when you need to do things over and over again until some condition 
// is fulfilled
//for (; ; )
//{
//    Console.WriteLine("Please enter a name");
//    string input = Console.ReadLine();
//    if(input.ToLower() == "martin")
//    {
//        Console.WriteLine("Hello there " + input);
//    }
//    if (input == "e" || input == "E")
//        break;
//}

//int start = int.Parse(Console.ReadLine());
//int end = int.Parse(Console.ReadLine());

//for(int i = start; i <= end; i++)
//{
//    Console.Write(i);
//}


//Console.WriteLine("Creating the droid army....");
//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("Assembling Droid Batalion " + i);
//    Thread.Sleep(1000);

//    if(i == 5)
//    {
//        Console.WriteLine("Problem in assembling with Droid batalion " + i);
//        continue;
//    }
//    if(i == 7)
//    {
//        Console.WriteLine("Droid assembler broke down!");
//        break;
//    }

//    Console.WriteLine("Droid batalion " + i + " is operational!");
//}
#endregion


#region  while, do/while,

// Simple while loop in C#
int count = 0;
while (count < 10)
{
    Console.WriteLine(count);
    count++;
}


// Infinite while loop - Don't try this at home :) !!!
//while (true)
//{
//    Console.WriteLine("This will go on forever!");
//}
//Console.WriteLine("Please enter your name: ");
//string userInput = Console.ReadLine();

//while(userInput != "martin")
//{
//    Console.WriteLine("Please enter your name: ");
//    userInput = Console.ReadLine();
//}

//while (true)
//{
//    if(userInput == "martin")
//    {
//        break;
//    }
//    Console.WriteLine("Please enter your name:");
//    userInput = Console.ReadLine();
//}

//int counter = 0;

//do
//{
//    Console.WriteLine("Hello there " + userInput);
//    counter++;
//} while (counter < 2);

#endregion


#region Arrays and array methods

//Array declaration 

// We can declare array in C# in few ways:

// 1. Declare the array by specifying
//    the number of elements in it like: new int[5]
int[] numberArray = new int[5];


// 2. Declare the array by initializing it
//    without specifying number of elements in it

string student = "Antonio";
string[] nameArray = new string[] {"Martin", "Tosho", "Monika", student};


// 2. Declare the array by by specifying
//    the number of elements and initializing it
//    in the same time

double[] decimalArray = new double[3] { 1.2, 2.5, 3.4 };

bool[] boolArray = new bool[3];
boolArray[0] = true;
boolArray[1] = false;
boolArray[2] = true;
Console.WriteLine(boolArray[2]);

char[] charArray = new char[4] { 'S', 'E', 'D', 'C'};

// Access an element of the array


Console.WriteLine(numberArray);

// This will print 0 because numberArray is array of ints and it is EMPTY!!!
// Because the default value of all integeres in c# is 0
Console.WriteLine(numberArray[2]);



Console.WriteLine(nameArray);
Console.WriteLine(nameArray[2]);


for(int i = 0; i < nameArray.Length; i++)
{
    Console.WriteLine(nameArray[i]);
}



// This will not work! The array is already declared with 4 elements
// No more elements can be addaed further except by using Resize() method

//nameArray[5] = "Mihail";
//Console.WriteLine(nameArray[5]);


// Get value from array using IndexOf()
int index = Array.IndexOf(nameArray, "Tosho");
Console.WriteLine("Array INDEX: " + index);



// Resize an array by using Resize() method

Array.Resize(ref nameArray, 10);

nameArray[4] = "Damjan";
Console.WriteLine(nameArray[4]);

foreach(string name in nameArray)
{
    Console.WriteLine(name);
}

Console.WriteLine("===========================");

Array.Reverse(nameArray);

foreach (string name in nameArray)
{
    Console.WriteLine(name);
}

Array.Clear(nameArray);

Console.WriteLine(nameArray[3]);

#endregion


#region Class exercises

// Exercise 1: Numbers up to your input and from your input

//Console.WriteLine("Please enter number: ");
//bool isParsed = int.TryParse(Console.ReadLine(), out int number);

//if (isParsed)
//{
//    Console.WriteLine("Your numbers from 1 to " + number);
//    for(int i = 1; i <= number; i++)
//    {
//        Console.WriteLine(i);
//    }
//    Console.WriteLine("Your numbers from " + number + "to 1");
//    for(int i =  number; i >= 1; i--)
//    {
//        Console.WriteLine(i);
//    }
//}
//else
//{
//    Console.WriteLine("You have not entered a number! Please try again!");
//}



// Exercise 2 : Evens and Odds

//if (isParsed)
//{
//    Console.WriteLine("Even numbers up to your inserted number:");
//    for (int i = 1; i <= number; i++)
//    {
//        if(i % 2 == 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//    Console.WriteLine("Even numbers up to your inserted number:");
//    for (int i = 1; i <= number; i++)
//    {
//        if (i % 2 == 1)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//else
//{
//    Console.WriteLine("You have not entered a number! Please try again!");
//}


// Exercise 3
//if (isParsed)
//{
//    Console.WriteLine("Your numbers from 1 to " + number);
//    for (int i = 1; i <= number; i++)
//    {
//        if (i % 3 == 0 || i % 7 == 0)
//        {
//            continue;
//        }
//        if (i == 100)
//        {
//            Console.WriteLine("The limit is reached and stop counting");
//            break;
//        }
//        Console.WriteLine(i);
//    }
//}
//else
//{
//    Console.WriteLine("You have not entered a number! Please try again!");
//}


// Exercise 4
//string[] wordsArray = new string[5] { "apple", "banana", "cherry", "date", "elderberry" };
//double[] decimalArray = new double[5] { 1.2, 3.4, 5.6, 7.8, 9.0 };
//char[] keyboardArray = new char[5] { 'a', 'b', 'c', 'd', 'e' };
//bool[] boolArray = new bool[5] { true, false, false, true, true };
//int[][] twoDArray = new int[2][] { new int[] { 1, 2}, new int[] { 4, 5} };







// Exercise 5
//int[] numbersArray = new int[5];

//for (int i = 0; i < numbersArray.Length; i++)
//{
//    Console.Write($"Enter value {i + 1}: ");
//    numbersArray[i] = int.Parse(Console.ReadLine());
//}

//int sum = 0;
//foreach (int number in numbersArray)
//{
//    sum += number;
//}

Console.WriteLine($"The sum of the numbers is: {sum}");

// Exercise 6
//string[] namesArray = new string[int.MaxValue];
//int index = 0;
//string input = "";

//do
//{
//    Console.Write("Enter a name: ");
//    input = Console.ReadLine();
//    namesArray[index] = input;
//    index++;

//    Console.Write("Do you want to enter another name? (Y/N): ");
//    input = Console.ReadLine();
//}
//while (input.ToUpper() == "Y");

//Console.WriteLine("All entered names:");
//for (int i = 0; i < index; i++)
//{
//    Console.WriteLine(namesArray[i]);
//}

#endregion
