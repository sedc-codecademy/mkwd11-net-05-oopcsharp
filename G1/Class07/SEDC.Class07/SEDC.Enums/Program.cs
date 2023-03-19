using SEDC.Enums.Enums;
using SEDC.Methods;

int monday = Convert.ToInt32(DaysOfWeek.Monday);

int march = Convert.ToInt32(Months.March);


Console.WriteLine(DaysOfWeek.Saturday);
Console.WriteLine(DaysOfWeek.Sunday);

Console.WriteLine(monday);
Console.WriteLine(march);

Console.WriteLine(Months.February.ToString());

if ("January" == Months.January.ToString())
{
    Console.WriteLine("Hello from January");
}



if (1 == Convert.ToInt32(Months.April))
{
    Console.WriteLine("Hello from april!");
}




CustomMath math = new CustomMath();
math.Sum(10, 20);
math.Sub(20, 5);