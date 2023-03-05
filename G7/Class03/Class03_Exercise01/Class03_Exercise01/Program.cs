namespace Class03_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();

            if(!int.TryParse(input, out int number1))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            for(int i = 1; i <= number1; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Please enter a number:");
            string input2 = Console.ReadLine();

            if (!int.TryParse(input2, out int number2))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            for(int i  = number2; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}