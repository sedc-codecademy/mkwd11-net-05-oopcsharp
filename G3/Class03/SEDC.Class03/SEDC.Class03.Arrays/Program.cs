// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// empty array with 3 elements
int[] emptyIntArray = new int[3];
// add values in the array
emptyIntArray[0] = 213;
emptyIntArray[1] = -21;
emptyIntArray[2] = 3;
//read value
int a = emptyIntArray[0];

// What an array looks like in the console
Console.WriteLine(emptyIntArray);
// read value
Console.WriteLine(emptyIntArray[2]);

// Trying to set a 4th item in the array
// emptyIntArray[3] = 123; // Index will be out of bound

string[] fullStringArray = 
    new string[] { "Bob", "Jill", "Kenny", "March" };
bool[] booleanArray = new bool[] { true, false };
char[] charArray = new char[] { '1', 'a', '3' };

long[] longArray = new [] { 1231231231111111111, 123123123, 1231231 };

short[] shortArray = { 1, 2, 3, 4, 5 };




double[] doubleArray = new double[] { 2.4, 11, 12, 634, 0.99 };
// Getting the number of elements from an array
Console.WriteLine(doubleArray.Length);

// reverse array
Array.Reverse(doubleArray);
Console.WriteLine(doubleArray[0]);

// Finding some item in array
int indexFound = Array.IndexOf(doubleArray, 12);
Console.WriteLine(indexFound);
Console.WriteLine(doubleArray[indexFound]);

int indexNotFound = Array.IndexOf(doubleArray, 5.5);
Console.WriteLine(indexNotFound);

// change array length
Array.Resize(ref doubleArray, doubleArray.Length + 1);
doubleArray[5] = 105.6;
Console.WriteLine(doubleArray[5]);


string[] names = { "Will", "Sam", "Fiona", "May" };

foreach(string name in names)
{
    //Console.WriteLine(name);
    Console.WriteLine("Checking if name is Sam...");
    if(name == "Sam")
    {
        Console.WriteLine("We found Sam!");
        break;
    }
}



// int[][] a = new int[][] { new[] { 1, 2 }, new[] { 1, 2 } };