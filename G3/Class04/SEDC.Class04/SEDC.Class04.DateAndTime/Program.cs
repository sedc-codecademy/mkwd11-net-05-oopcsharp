// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


DateTime aDate = new DateTime();
Console.WriteLine(aDate);

DateTime bDate = new DateTime(1992, 10, 15);
Console.WriteLine(bDate);

// Converting from string to DateTime
// Variations:
//string stringDate = "12.15.2012";
//string stringDate = "12/15/2012";
//string stringDate = "12/15/12";
//string stringDate = "dec.15.12";
string stringDate = "12-15-2012";

DateTime convertedDate = DateTime.Parse(stringDate);
Console.WriteLine(convertedDate);

DateTime today = DateTime.Today;
Console.WriteLine(today);

DateTime currentLocalDateTime = DateTime.Now;
DateTime currentUTCtime = DateTime.UtcNow;
Console.WriteLine(currentLocalDateTime);
Console.WriteLine(currentUTCtime);

int month = currentLocalDateTime.Month;
int year = currentLocalDateTime.Year;
int day = currentLocalDateTime.Day;
Console.WriteLine(month);
Console.WriteLine(year);
Console.WriteLine(day);

DateTime addedMonths = currentLocalDateTime.AddMonths(1); // add month
DateTime removeMonths = currentLocalDateTime.AddMonths(-1); // remove month
Console.WriteLine(addedMonths);
Console.WriteLine(removeMonths);

currentLocalDateTime.AddDays(1); //add
currentLocalDateTime.AddDays(-1); //remove
currentLocalDateTime.AddYears(1); // add
currentLocalDateTime.AddYears(-1); // remove

currentLocalDateTime.AddHours(1);
currentLocalDateTime.AddMinutes(1);

string dateFormat1 = currentLocalDateTime.ToString("MM/dd/yyyy");
string dateFormat2 = currentLocalDateTime.ToString("dddd, dd MMMM yyyy");
Console.WriteLine(dateFormat1);
Console.WriteLine(dateFormat2);
string dateFormat3 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}"
    , currentLocalDateTime);
Console.WriteLine(dateFormat3);


DateTime yesterday =  currentLocalDateTime.AddDays(-1);
Console.WriteLine(yesterday);