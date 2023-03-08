namespace Class04_Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");

            if(!int.TryParse(Console.ReadLine(), out int number) /*|| number > text.Length*/)
            {
                Console.WriteLine("Wrong input or number exeeds text length");
                return;
            }

            Substring(number);
        }

        static void Substring(int n)
        {
            string text = "Hello from SEDC Codecademy 2023";

            if (n > text.Length)
            {
                n = text.Length;
            }

            //if(n > text.Length)
            //{
            //    Console.WriteLine($"Our text has {text.Length} chars and {n} chars cannot be accessed");
            //    return;
            //}

            string substring = text.Substring(0, n);

            Console.WriteLine(substring.Length);
            Console.WriteLine(substring);
        }
    }
}