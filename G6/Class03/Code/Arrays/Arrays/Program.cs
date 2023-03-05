//Array of whole numbers, containing 3 elements

int[] arrayOfInts = new int[3]; //here 3 is not an index, it represents the number of members

arrayOfInts[0] = 4; //initialize the first member
arrayOfInts[1] = 7; //initialize the first member
arrayOfInts[2] = 9; //initialize the first member

//Console.Write(arrayOfInts);

//access a member
//second member
Console.WriteLine("First member: " + arrayOfInts[0]);
Console.WriteLine("Second member: " + arrayOfInts[1]);
Console.WriteLine("Third member: " + arrayOfInts[2]);


//declare and initialize strings array
//C# from the given values will see how many members we will have in the array
string[] arrayOfStrings = new string[] { "Hello", "SEDC", "Goodbye", "C#" };

short[] arrayOfShorts = new short[] { 2, 5, 7 };
int[] anotherIntArray = new int[] { 2, 66, 88, 907 };
bool[] boolArray = new bool[] { false, true };

bool[] anotherBoolArray = new bool[2]; //this will be an array of two bool values
anotherBoolArray[0] = true;
anotherBoolArray[1] = false;

Console.WriteLine("third member of arrayOfStrings: " + arrayOfStrings[2]);

//Methods 
double[] doubleArray = new double[] { 3.4, 6.7, 8, 9.1, 100.5 }; //array of 5 doubles
//length
Console.WriteLine("Num of elements in doubleArray: " + doubleArray.Length);

//change number of members
Array.Resize(ref doubleArray, 7);
Console.WriteLine("Num of elements in doubleArray: " + doubleArray.Length);
Console.WriteLine("Sixth member of doubleArray: " + doubleArray[5]);
doubleArray[5] = 12.2;
doubleArray[6] = 20.7;
Console.WriteLine("Num of elements in doubleArray: " + doubleArray.Length);
Console.WriteLine("Sixth member of doubleArray: " + doubleArray[5]);

int indexOfEight = Array.IndexOf(doubleArray, 8);
Console.WriteLine("Index of 8: " + indexOfEight);

int indexOfEleven = Array.IndexOf(doubleArray, 11);
Console.WriteLine("Index of 11: " + indexOfEleven);

//Foreach
Console.WriteLine("====Foreach====");
string[] names = new string[] { "Ana", "Marko", "Stefan", "Kate", "Nikola" };

for(int i = 0; i < names.Length; i++)
{
    Console.WriteLine("Index: " + i);
    Console.WriteLine("Value: " + names[i]);
}

Console.WriteLine("====Foreach example====");
foreach (string name in names)
{
    Console.WriteLine(name);
}

Array.Reverse(names);
Console.WriteLine("===Reverse===");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Array of arrays
int[][] matrix = new int[][]
{
    new int[] {1, 2},
    new int[] {6, 7},
    new int[] {10, 157}
};

//matrix[0] -> new int[] {1, 2}
Console.WriteLine(matrix[0][1]); //2
//matrix[2] ->  new int[] {10, 157}
Console.WriteLine(matrix[2][0]); //10

foreach (int[] row in matrix)
{
    foreach(int num in row)
    {
        Console.WriteLine(num);
    }
}
