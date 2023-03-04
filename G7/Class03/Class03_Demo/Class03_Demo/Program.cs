namespace Class03_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello, World!");
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    break;
                }

                Console.WriteLine($"Iteration: {i}");
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    continue;
                }

                Console.WriteLine($"Iteration: {i}");
            }

            Console.WriteLine("Out of the loops");

            Console.WriteLine("While loop...");
            int j = 0;

            while (j < 10)
            {
                Console.WriteLine("Hello, World!");
                j++;
            }


            Console.WriteLine("Do While loop...");

            int k = 0;

            do
            {
                Console.WriteLine("Hello, World!");
                k++;
            } while (k < 10);
        }
    }
}