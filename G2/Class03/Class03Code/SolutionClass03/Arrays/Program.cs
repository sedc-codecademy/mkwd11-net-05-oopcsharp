//empty integer array with lenght 3
int[] emptyIntegerArray = new int[3];
emptyIntegerArray[0] = 5;
emptyIntegerArray[1] = 7;
emptyIntegerArray[2] = 33;

Console.WriteLine(emptyIntegerArray[1]);
//emptyIntegerArray[3] = 55; -error, out of range boundaries

string[] stringArray = { "Damjan", "Slave", "Elena" };
int[] intArray = {2, 64, 789};
Console.WriteLine(stringArray[2]);
// Lenght give as a number of elements
Console.WriteLine($"StringArray lenght: {stringArray.Length}");

//double[] doubleArray = { 2, 33.3, 44.6, true }; - mixed arrays are not allowed
double[] doubleArray = { 2, 33.3, 44.6, 7, 234 };
//doubleArray[5] = 55.9; -exception
doubleArray[4] = 7658;
Console.WriteLine(doubleArray[4]);

//RESIZE
Array.Resize(ref doubleArray, 7);
doubleArray[5] = 55.9;
Console.WriteLine(doubleArray[5]);

//INDEX OF
int indexFound = Array.IndexOf(doubleArray, 44.6);
Console.Write("Index of 44.6: ");
Console.WriteLine(indexFound);

//Reverse
Console.WriteLine("==REVERSE==");
//doubleArray[6] = 5;
Console.WriteLine(doubleArray[0]);
Array.Reverse(doubleArray);
Console.WriteLine(doubleArray[0]);

string[] names = { "Dana", "Luka", "Kiril", "Leo", "Marko" };

foreach(string name in names)
{
    Console.WriteLine(name);
    if (name == "Kiril")
        break;
}



