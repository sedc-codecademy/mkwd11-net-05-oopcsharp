namespace Class03_Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[10];

            string[] names = new string[5];

            names[1] = "Risto";
            names[1] = "Marko";

            //names[5] = "Panchevski"; => throws error that index is out of range (array has indexes from 0 - 4)

            char[] letters = new char[6] { 'C', 'D', 'A', 'B', 'X', 'Y' };

            Console.WriteLine(letters[3]);

            double[] d = new double[] { 1.02, 33.3, 44.4 };

            float[] floatArray = new float[] { 1.02f, 33.3f, 44.4f };

            int[] evenNumbers = new int[] { 2, 4, 6, 8, 10, 12, 14, 10, 8, 12 };

            float[] array1 = new float[] { 2.2f, 3.3f, 2 };

            int result = Array.IndexOf(evenNumbers, 10);
            int result1 = Array.IndexOf(evenNumbers, 11);

            int numberOnIndex5 = evenNumbers[5];

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(numberOnIndex5);

            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //1, 2, 3 => index 0
            //4, 5, 6 => index 1
            //7, 8, 9 => index 2

            Console.WriteLine(matrix[1, 1]);

            Array.Reverse(evenNumbers);

            string[] students = new string[3] { "Marko", "Frosina", "Ana" };

            //students[3] = "Christos"; => error out of bound

            Array.Resize(ref students, 4);
            students[3] = "Christos";

            Console.WriteLine(students.Length);

            //PRINT ARRAYS

            foreach(string name in students)
            {
                Console.WriteLine(name);
                //Console.Write($"{name}, ");
            }

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            string s = "Risto";
            Console.WriteLine(s.Length);
        }
    }
}