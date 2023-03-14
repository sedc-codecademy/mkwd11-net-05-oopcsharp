using System.Globalization;
using System.Text;

namespace Class04_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Changing the Encoding, and setting it to UTF8 allows us to print out cyrillic in the console
            Console.OutputEncoding = Encoding.UTF8;
            string firstName = "Risto";
            string secondName = "Panchevski";

            //string fullName = firstName + secondName;

            //string fullName = firstName + " " + secondName;
            //string fullName = string.Format("Hello: {0} {1} {0}", firstName, secondName);
            string fullName = $"Hello: {firstName} {secondName}";
            Console.WriteLine(fullName);

            double amount = 1000000.5;

            string currency = string.Format("{0:C}", amount);
            Console.WriteLine(currency);
            Console.WriteLine($"{amount:C}");

            int phoneNumber = 070123456;
            Console.WriteLine(string.Format("{0:0##/###-###}", phoneNumber));

            Console.WriteLine(amount.ToString("C", new CultureInfo("el-GR")));


            decimal d = 0.5M;
            Console.WriteLine($"{d:P}");

            string[] students = new string[] { "Marko", "Ana", "Martin" };

            Console.WriteLine(string.Format("| {0,10}| {1,10}|", "Id", "Name"));
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"| {i + 1, 10}| {students[i], 10}|");
            }

            string s1 = "We will have \"fair\" elections";
            Console.WriteLine(s1);

            string s2 = "Check your c:\\ drive";
            Console.WriteLine(s2);

            string s3 = "Hello,\nRisto";
            Console.WriteLine(s3);

            string s4 = @"C:\SEDC\2022-2023\[5] C# Basic";
            Console.WriteLine(s4);

            string welcomeMessage = "Welcome to SEDC. We wish you all the best. Happy IWD!";

            Console.WriteLine(welcomeMessage.ToLower());
            Console.WriteLine(welcomeMessage.ToUpper());
            Console.WriteLine(welcomeMessage.Length);

            Console.WriteLine(welcomeMessage.Remove(0, 8));
            Console.WriteLine(welcomeMessage.Replace(" ", ""));

            string[] words = welcomeMessage.Split(' ');
            string[] sentences = welcomeMessage.Split('.');

            int indexOfSEDCString = welcomeMessage.IndexOf("SEDC");
            int indexOfSeavusString = welcomeMessage.IndexOf("Seavus");
            bool existsSEDC = welcomeMessage.Contains("SEDC");
            bool existsSeavus = welcomeMessage.Contains("Seavus");

            bool startsWithW = welcomeMessage.StartsWith("Welcome");
            Console.WriteLine(welcomeMessage.Substring(8, 2));

            char[] welcomeMessageChars = welcomeMessage.ToCharArray();

            string name = "   Risto   ";
            Console.WriteLine(name.Trim());

            string result = string.Join(", ", students);
            Console.WriteLine(result);

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            bool e1 = numbers.Contains(7);
            bool e2 = numbers.Contains(8);

            string fileName = "text.txt";
            string s5 = @$"C:\SEDC\2022-2023\[5] C# Basic\{fileName}";

            decimal amountDollars = 10000.50M;
            Console.WriteLine($"{amountDollars:C}");
            Console.WriteLine(amountDollars.ToString("C", new CultureInfo("en-US")));

            decimal percent = 0.3333M;
            Console.WriteLine($"{percent:P}");
        }
    }
}