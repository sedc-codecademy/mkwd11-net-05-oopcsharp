#region Arrays

string[] stringArray = new string[2];
stringArray[0] = "John";
stringArray[1] = "Doe";

int[] intArray = new int[] { 1, 5, 15, 5, 10, 5 };

char[] charArray = new char[4];
charArray[0] = 'S';
charArray[1] = 'E';
charArray[2] = 'D';
charArray[3] = 'C';


int[] secondIntArray = new int[10];

string[] secondStringArray = new string[10];

#endregion

#region Array Methods

//Changes the size of the array
Array.Resize(ref stringArray, 3);
stringArray[2] = "Angel";

Array.Resize(ref intArray, intArray.Length + 1);
intArray[intArray.Length - 1] = 100;

//Clears the whole array or part of it
//Array.Clear(intArray);
//Array.Clear(intArray, 3, 2);

// Returns the index of the value
// If not found returns -1
// If there is multiple indexes with identical value returns the first
int indexFound = Array.IndexOf(intArray, 5, 2, 2);
Console.WriteLine($"Found index: {indexFound}");


// Reverses the array
Array.Reverse(intArray);

// Fills the array with given value
Array.Fill(secondIntArray, 100);

#endregion

#region Two Dimensional Array

// Two Dimensional Array (array of arrays)

string[][] arrayOfArrays = new string[][]
{
    new string[] {"SEDC"},
    new string[] {"John", "Doe"},
    new string[] {"G1", "G2"}
};

Array.Resize(ref arrayOfArrays[0], 2);
arrayOfArrays[0][1] = "Brainster";

foreach (string[] array in arrayOfArrays)
{
    foreach (string arrayItem in array)
    {
        Console.WriteLine(arrayItem);
    }
}

#endregion


//foreach (string arrayItem in secondStringArray)
//{
//    Console.WriteLine(arrayItem);
//}


//foreach (int arrayItem in secondIntArray)
//{
//    Console.WriteLine(arrayItem);
//}


//foreach (char arrayItem in charArray)
//{
//    Console.WriteLine(arrayItem);
//}


//foreach (int arrayItem in intArray)
//{
//    Console.WriteLine(arrayItem);
//}


//foreach (string arrayItem in stringArray)
//{
//    Console.WriteLine(arrayItem);
//}
