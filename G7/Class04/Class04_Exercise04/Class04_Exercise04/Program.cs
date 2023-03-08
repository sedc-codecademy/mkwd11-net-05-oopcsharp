using System.Text;

namespace Class04_Exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Print the date that is 3 days from now
            Console.WriteLine(DateTime.Now.AddDays(3));
            //Print the date that is one month from now
            Console.WriteLine(DateTime.Now.AddMonths(1));
            //Print the date that is one month and 3 days from now
            Console.WriteLine(DateTime.Now.AddMonths(1).AddDays(3));
            //Print 1 year and 2 months ago from today
            Console.WriteLine(DateTime.Now.AddYears(-1).AddMonths(-2));
            //Print only the current month of today
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            //Print only the current year of today
            Console.WriteLine(DateTime.Now.Year);
            //UTCNow +10 hours
            Console.WriteLine(DateTime.UtcNow.AddHours(10));
        }
    }
}