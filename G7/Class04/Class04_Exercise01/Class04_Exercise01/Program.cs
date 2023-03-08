namespace Class04_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert operation (+, -):");

            string inputOperator = Console.ReadLine();

            if (inputOperator != "+" && inputOperator != "-")
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Please insert the first number:");
            string firstInput = Console.ReadLine();

            if (!int.TryParse(firstInput, out int firstNumber))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Please insert the second number:");
            string secondInput = Console.ReadLine();

            if (!int.TryParse(secondInput, out int secondNumber))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            switch (inputOperator)
            {
                case "+":
                    Console.WriteLine($"Result: {Sum(firstNumber, secondNumber)}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {Subtract(firstNumber, secondNumber)}");
                    break;
                default:
                    Console.WriteLine("Wrong operator");
                    break;
            }
        }

        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}