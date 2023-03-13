//empty DateTime
DateTime emptyDateTime = new DateTime();
Console.WriteLine(emptyDateTime);

//create DateTime with current date and time (local date and time, from the server)
DateTime currentDateTime = DateTime.Now; 
Console.WriteLine(currentDateTime);

//create DateTime with specific date
DateTime specificDate = new DateTime(1994, 4, 3);
Console.WriteLine(specificDate);

DateTime anotherDate = new DateTime(2022, 9, 6, 12, 34, 45);
Console.WriteLine(anotherDate);

//string dateString = "05-02-2023";
//string dateString = "05.02.2023";
//parse the date string, pass a string in the format for dates from the server
DateTime parsedDate = DateTime.Parse("02/05/2023");
Console.WriteLine(parsedDate);

DateTime universalDateTime = DateTime.UtcNow;
Console.WriteLine(universalDateTime);

//get the current day of the current month
int day = currentDateTime.Day;
Console.WriteLine($"current day: {day}");

//get the current month
int month = currentDateTime.Month;
Console.WriteLine($"current month: {month}");

//get the current day of week
var dayOfWeek = currentDateTime.DayOfWeek;
Console.WriteLine(dayOfWeek);

//get current year
int year = DateTime.Now.Year;
Console.WriteLine($"current year: {year}");

DateTime firstDateTime = new DateTime(2000, 2, 3, 13, 45, 45);
DateTime secondDateTime = new DateTime(2020, 5, 3, 13, 45, 45);

//difference is of type TimeSpan
var difference = secondDateTime - firstDateTime;
Console.WriteLine(difference);

//get the date and time 5 days from now
DateTime fiveDaysAhead = DateTime.Now.AddDays(5);
Console.WriteLine(fiveDaysAhead);

//get the date time 5 days and 5 hours from now
//DateTime fiveDaysAndHoursAhead = DateTime.Now.AddDays(5).AddHours(5);
DateTime fiveDaysAndHoursAhead = fiveDaysAhead.AddHours(5);
Console.WriteLine(fiveDaysAndHoursAhead);

//get the date and time 2 years and 3 months ago
DateTime twoYearsAndThreeMonthsAgo = DateTime.Now.AddYears(-2).AddMonths(-3);
Console.WriteLine(twoYearsAndThreeMonthsAgo);

//long timeTicks = 1234567890; // replace with your time tick value
//TimeSpan timeSpan = new TimeSpan(timeTicks);
int days = difference.Days;
int hours = difference.Hours;
Console.WriteLine($"Days: {days}, Hours: {hours}");

//Formatting datetime to string
string formattedDate = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(formattedDate);
string secondFormattedDate = DateTime.Now.ToString("dddd.MMMM.yy");
Console.WriteLine(secondFormattedDate);
string thirdFormattedDate = string.Format("Today is {0:dd-MMM-yyyy hh:mm}", DateTime.Now);
Console.WriteLine(thirdFormattedDate);

