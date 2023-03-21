using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class09.ExceptionHandling
{
    public class Parsers
    {
        public int FromStringToInt()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("ENter number");
                    string input = Console.ReadLine();
                    int number = int.Parse(input);
                    return number;
                }
                catch(ArgumentNullException ex)
                {
                    Console.WriteLine("Please enter a valid value, null is not supported!");
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Please enter valid text format. ex: 1, 123");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("The number you have entered is larger that the number we support");
                }
                catch (Exception) 
                {
                    Console.WriteLine("Something went wrong. Please try again later!");
                }
            }
        }

        public int FromStringToIntTryParse()
        {
            while (true)
            {
                Console.WriteLine("Enter number");
                string input = Console.ReadLine();
                bool isValidNumber = int.TryParse(input, out int value);
                if (isValidNumber)
                {
                    return value;
                }
                Console.WriteLine("Please enter valid number");
            }
        }
    }
}
