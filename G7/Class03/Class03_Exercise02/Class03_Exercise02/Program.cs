namespace Class03_Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");

            string inputFirstNumber = Console.ReadLine();
            int firstNumber;

            bool firstNumberSuccessParse = int.TryParse(inputFirstNumber, out firstNumber);

            if (!firstNumberSuccessParse)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            for (int i = 2; i <= firstNumber; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Even number {i}");
                } 
                //else
                //{
                //    Console.WriteLine($"Odd number {i}");
                //}
            }

            //int k = 2;
            //while (k <= firstNumber)
            //{
            //    if (k % 2 == 0)
            //    {
            //        Console.WriteLine(k);
            //    }
            //    k++;
            //}

            //for (int j = 2; j <= firstNumber; j += 2)
            //{
            //    Console.WriteLine(j);
            //}

            int secondNumber;


            //1. input
            //2. Check the input
            //3. IF correct move on
            //4. If not, input once again (go to 1.)

            while(true)
            {
                Console.WriteLine("Please insert second number:");
                string inputSecondNumber = Console.ReadLine();

                bool secondNumberSuccessParse = int.TryParse(inputSecondNumber, out secondNumber);

                if(secondNumberSuccessParse)
                {
                    break;
                } else
                {
                    Console.WriteLine("Wrong input");
                }
            }

            for (int z = 1; z <= secondNumber; z+=2)
            {
                Console.WriteLine(z);
            }
        }
    }
}