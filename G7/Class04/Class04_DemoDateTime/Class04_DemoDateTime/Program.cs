using System.Globalization;
using System.Text;

namespace Class04_DemoDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime date;
            date = new DateTime();
            DateTime yearAgo = new DateTime(2022, 3, 8, 14, 50, 30);
            DateTime now = DateTime.Now;
            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine(now);
            Console.WriteLine(now.AddDays(2));
            Console.WriteLine(now.AddDays(-2));


            DateTime date1 = new DateTime(2023, 3, 30, 14, 50, 30);
            Console.WriteLine(date1.AddMonths(-1));

            Console.WriteLine(date1.Day);
            Console.WriteLine(date1.DayOfYear);
            Console.WriteLine(date1.DayOfWeek);

            Console.WriteLine(now);
            Console.WriteLine(now.ToString("dd*MMMM*yyyy HH-mm-ss", new CultureInfo("en-GB")));
            Console.WriteLine(now.ToString("dd*MMMM*yyyy HH-mm-ss"));
        }
    }
}