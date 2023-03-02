namespace Class02_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int numberOfStudents;
            //numberOfStudents = 17;

            int numberOfStudents = 17;

            numberOfStudents = 15;

            //int a, b;

            //a = 1;
            //b = 2;

            int a = 1, b = 2;

            a = 1111111111;

            long largeNumber;
            largeNumber = 11111111111;

            Console.WriteLine(largeNumber);

            short smallNumber = 11111;

            //float denarEuroRateFloat = 61.5f;
            float denarEuroRateFloat = 61.5F;

            //double denarEuroRateDouble = 61.5;
            //double denarEuroRateDouble = 61.5D;
            double denarEuroRateDouble = 61.5d;

            //decimal denarEuroRateDecimal = 61.5m;
            decimal denarEuroRateDecimal = 61.5M;

            float dollarToDenarRateFloat = 60.5f;

            bool doYouLikeThisClass;
            doYouLikeThisClass = true;
            doYouLikeThisClass = false;

            Console.WriteLine(doYouLikeThisClass);
            //int doYouLikeThisClass; => gives an error because I cannot change variable Data type

            string firstName = "Risto";
            Console.WriteLine(firstName);

            char sign = 'x';
            //sign = "C"; => gives an error because double quotes are specifing string
            Console.WriteLine(sign);

            DateTime date;
            date = new DateTime(2023, 3, 2);
            date = new DateTime(2023, 3, 2, 19, 37, 5);
            Console.WriteLine(date);

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime utcTime = DateTime.UtcNow;
            Console.WriteLine(utcTime);

            int x = 1, y = 2;

            int sum = x + y;

            Console.WriteLine(sum);

            int t = 5, z = 6;

            Console.WriteLine(t);

            t = t * z;
            t *= z;

            Console.WriteLine(t);
        }
    }
}