#region DateTime
//Creating an empty DateTime
DateTime dateTime = new DateTime(); // Creates an empty DateTime object with a default value of 01/01/0001 12:00:00PM
Console.WriteLine(dateTime);

//Creating a custom date          Year Month Day
DateTime customDate = new DateTime(1998,02,07);// Creates a DateTime object with the specified year, month, day, hour, minute, and second
Console.WriteLine(customDate);
//The line bellow is commented out because DateTime cant use negative numbers
//DateTime brokenTime = new DateTime(-1, 2, 5);

DateTime customDateTime = new DateTime(1998, 02, 07,8,36,45,42);// y/m/d/h/m/s/mil
Console.WriteLine(customDateTime);

// Creating a DateTime with the current Date and Time
DateTime nowDateTime = DateTime.Now;// Gets the current local DateTime
Console.WriteLine(nowDateTime);

// Creating a DateTime with the current Date
DateTime todayDate = DateTime.Today; //Date, Time default

Console.WriteLine(todayDate);


int year = nowDateTime.Year;
int month = todayDate.Month;
int day = todayDate.Day;
int hour = todayDate.Hour;

int dayOfYear = todayDate.DayOfYear;
Console.WriteLine("Day:" + dayOfYear);

DateTime addYear = todayDate.AddYears(5);// Adds 5 year to the DateTime
DateTime addMonth = todayDate.AddMonths(5);// Adds 5 months to the DateTime
DateTime addDays = todayDate.AddDays(7);// Adds 7 days to the DateTime
Console.WriteLine("Add Year:" + addYear);
Console.WriteLine("Add Month:" + addMonth);
DateTime removeYear = todayDate.AddYears(-5); // Remove 5 days to the DateTime
Console.WriteLine("Remove Year:" + addYear);


//Converting from string to DateTime
string stringDate = "12.15.2022";
string stringDate1 = "12/15/2012";
string stringDate2 = "12/15/12";
string stringDate3 = "dec.15.12";
string stringDate4 = "12-15-2012";
DateTime stringDateTime = DateTime.Parse(stringDate);
DateTime convertedDate1 = DateTime.Parse(stringDate1);
DateTime convertedDate2 = DateTime.Parse(stringDate2);
DateTime convertedDate3 = DateTime.Parse(stringDate3);
DateTime convertedDate4 = DateTime.Parse(stringDate4);
Console.WriteLine(stringDateTime);
Console.WriteLine(convertedDate1);
Console.WriteLine(convertedDate2);
Console.WriteLine(convertedDate3);
Console.WriteLine(convertedDate4);

bool isParsedDateTime = DateTime.TryParse(stringDate, out DateTime convertedDate);
if (isParsedDateTime)
{
    Console.WriteLine(convertedDate);
}
else
{
    Console.WriteLine("Wrong parsed");
}


Console.WriteLine("===== Formating datetime =======");

DateTime today = DateTime.Now;

string dateFormatOne = today.ToString("MM/dd/yyyy");// 03/08/2023
Console.WriteLine(dateFormatOne);
string dateFormat2 = today.ToString("dd.MM.yyyy");// 08.03.2023
Console.WriteLine(dateFormat2);
string dateFormat3 = today.ToString("dddd,  dd.MM.yyyy");// Wednesday, 08.03.2023
Console.WriteLine(dateFormat3);
string dateFormat4 = today.ToString("dd-MM-yyyy HH:mm");// 08-03-2023 17:59
Console.WriteLine(dateFormat4);
#endregion

#region Exercise 4
DateTime todayExercise = DateTime.Today;
Console.WriteLine(todayExercise.AddDays(3));// 3/11/2023
Console.WriteLine(todayExercise.AddMonths(1).AddDays(3));// 4/11/2023
Console.WriteLine(todayExercise.AddYears(-1).AddMonths(-2));// 1/8/2022
Console.WriteLine(todayExercise.ToString("MMMM"));//March
Console.WriteLine(todayExercise.ToString("yyyy"));//2023
#endregion