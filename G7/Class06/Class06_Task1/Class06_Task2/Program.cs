using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace Class06_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0.Do -while loop that at end will ask the user to input Y or N, and based on that will proceed once again with steps 1 & 2
            //1.enter a loop, ask the user for input, check the input if it is a number, true - proceed, false - ask again
            //2.create a method that will be invoke after the correct input

            do
            {
                while (true)
                {
                    Console.Write("Enter a number:");
                    string input = Console.ReadLine();

                    if (!decimal.TryParse(input, out decimal number))
                    {
                        Console.WriteLine("Wrong input, please try again!");
                        continue;
                    }

                    Console.WriteLine($"Stats for number: {number}");
                    NumberStats(number);
                    break;
                }

                string secondInput;
                while (true)
                {
                    Console.WriteLine("If you want to proceed please enter Y, otherwise press N");
                    secondInput = Console.ReadLine();

                    if (secondInput.ToUpper() != "Y" && secondInput.ToUpper() != "N")
                    {
                        Console.WriteLine("Wrong input!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                if (secondInput.ToUpper() == "Y")
                {
                    continue;
                }
                else if (secondInput.ToUpper() == "N")
                {
                    break;
                }
            } while (true);
        }

        static void NumberStats(decimal n)
        {
            if (n > 0)
            {
                // \t - Tab; \n - New line
                Console.WriteLine("\t- Positive");
            }
            else if (n < 0)
            {
                Console.WriteLine("\t- Negative");
            }
            else
            {
                Console.WriteLine("\t- Neither positive nor negative");
            }

            //Decimal numbers are not even nither odd. Only integers are divided as even or odd numbers
            if (n % 1 == 0)
            {
                Console.WriteLine("\t- Integer");

                if (n % 2 == 0)
                {
                    Console.WriteLine("\t- Even");
                }
                else
                {
                    Console.WriteLine("\t- Odd");
                }
            }
            else
            {
                Console.WriteLine("\t- Decimal");
            }
        }
    }
}