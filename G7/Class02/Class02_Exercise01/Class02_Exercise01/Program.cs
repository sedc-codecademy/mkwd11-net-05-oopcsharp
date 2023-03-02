namespace Class02_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 01");

            double a = 55.5d;
            double b = 33.3d;

            double result = a / b;

            Console.WriteLine($"Result: {result}");

            int c = 5;
            int d = 2;

            int result1 = c / d;
            Console.WriteLine($"Result: {result1}");

            //int c = 5;
            //double d = 2d;
            //double result1 = c / d;
            //Console.WriteLine($"Result: {result1}");

            float result2 = c / (float) d;
            Console.WriteLine($"Result: {result2}");

            //int x = 1;
            //int y = 0;

            //int r = x / y; // throws an exception
        }
    }
}