

DateTime date = new DateTime();
Console.WriteLine(date);

DateTime currentDate = DateTime.Now;
Console.WriteLine(currentDate);

DateTime universalDateTime = DateTime.UtcNow;
Console.WriteLine(universalDateTime);


DateTime currentDay = DateTime.Today;
Console.WriteLine(currentDay);
Console.WriteLine(currentDate.Date);


DateTime newDate = new DateTime(1993, 08, 27);
Console.WriteLine(newDate);


// Add and subtract years 
DateTime currentDatePlusTwoYears = currentDay.AddYears(2);
//DateTime currentDateMinusTwoYears = currentDay.AddYears(-2).AddMonths(-2).AddDays(1).AddMinutes(2);


// Instead of creating multiple variables you can chain the methods like on the line 24 above
DateTime currentDateMinusTwoYears = currentDay.AddYears(-2);

DateTime currentDateMinusTwoYearsMinusTwoMonths = currentDateMinusTwoYears.AddMonths(-2);

DateTime currentDateMinusTwoYearsMinusTwoMonthsMinusTwoDays = currentDateMinusTwoYearsMinusTwoMonths.AddDays(-2);



Console.WriteLine(currentDatePlusTwoYears);
Console.WriteLine(currentDateMinusTwoYears);



// Parsing string into dates

string myBirthDay = "08/27/1993";
DateTime myBirthDate = DateTime.Parse(myBirthDay);
Console.WriteLine("I am born on " + myBirthDate);


string myBirthDateFormated = myBirthDate.ToString("dd/MM/yyyy");
string myBirthDateFormated1 = myBirthDate.ToString("dddd MMM yy");
string myBirthDateAndHour = myBirthDate.ToString("MM-dd-yyyy HH:mm:ss");


string formattedDate = string.Format("{0:dd-MMM-yyyy}", myBirthDate);

Console.WriteLine(myBirthDateFormated);
Console.WriteLine(myBirthDateFormated1);
Console.WriteLine(myBirthDateAndHour);
Console.WriteLine(formattedDate);


