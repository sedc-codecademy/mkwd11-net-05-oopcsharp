// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//default date
DateTime dt1 = new DateTime();
Console.WriteLine(dt1);

//custom date
DateTime dt2 = new DateTime(2023, 03, 16);
Console.WriteLine(dt2);

//custom date and time
DateTime dt3 = new DateTime(2023, 03, 16, 05, 05, 05);
Console.WriteLine(dt3);

//Today
DateTime dt4 = DateTime.Today;
Console.WriteLine(dt4);

//Now
DateTime currentdatetime = DateTime.Now;
Console.WriteLine(currentdatetime);

//AddDays -- adds days in some datetime variable, can accept postive and negative numbers
DateTime dt6 = currentdatetime.AddDays(-5);
Console.WriteLine(dt6);

//AddMonths
DateTime dt7 = currentdatetime.AddMonths(3);
Console.WriteLine(dt7);

//AddYears, AddHours....

//DATE TIME PROPERTIES
//Month - shows the month of the datetime variable
int month = currentdatetime.Month;
Console.WriteLine(month);

//Day - shows the day of the datetime variable
int day = currentdatetime.Day;
Console.WriteLine(day);

//Convert string to datetime
string datetimeconvert = "2023-01-01";
DateTime convertdatetime = Convert.ToDateTime(datetimeconvert);
Console.WriteLine(convertdatetime);

//String Format
string dateformat1 = string.Format("Today is: {0:dd/MM/yyyy}, {0:dddd}", currentdatetime);
Console.WriteLine(dateformat1);

string dateformat2 = string.Format("Today is: {0:dd-MM-yyyy}, {0:t}", currentdatetime);
Console.WriteLine(dateformat2);