using System.Globalization;

namespace Class04_DemoMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = 33.3;
            //Console.WriteLine(amount.ToString("C", new CultureInfo("en-GB")));
            Console.WriteLine(ConvertToCurrency(amount));


            double amount1 = 99.9;
            Console.WriteLine(ConvertToCurrency(amount1));


            double amount2 = 44.4;
            Console.WriteLine(ConvertToCurrency(amount2));


            double amount3 = 55.5;
            Console.WriteLine(ConvertToCurrency(amount3));


            float amount4 = 66.6f;
            Console.WriteLine(ConvertToCurrencyFloat(amount4));
        }

        static string ConvertToCurrency(double amount)
        {
            string formatedString = amount.ToString("C", new CultureInfo("en-US"));
            return formatedString;
        }
        static string ConvertToCurrencyFloat(float amount)
        {
            string formatedString = amount.ToString("C", new CultureInfo("en-US"));
            return formatedString;
        }

        //static void FuncThatDoesNotReturnAnything() //defining a function that does not return anything and has 0 input parameters
        //{
        //}
    }
}