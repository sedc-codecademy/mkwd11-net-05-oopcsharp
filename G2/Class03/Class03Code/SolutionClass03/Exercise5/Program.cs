string[] words = { "Hello", "Hi", "Wow", "Words", "Dog" };
double[] decimals = new double[] { 2.4, 34.5, 3.54, 65.23, 123.3 };
char[] chars = { 'a', '*', '&', 'd', 'e' };
bool[] bools = new bool[] { true, false, false, false, false };
int[][] arrayOfInts = new int[][]
{
    new int[] {2, 5},
    new int[] {6, 5},
    new int[] {6, 21},
    new int[] {9, 1},
    new int[] {10, 1}
};

Console.WriteLine("Words:");
foreach (string word in words)
{
    Console.WriteLine(word);
}

foreach(int[] arrayInteger in arrayOfInts)
{
    foreach(int integer in arrayInteger)
    {
        Console.WriteLine(integer);
    }
}
 