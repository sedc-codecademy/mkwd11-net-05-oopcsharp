using SEDC.Exercises_2;

Console.WriteLine("Please enter a number from 1-12");
bool canParse = int.TryParse(Console.ReadLine(), out int userInput);
if (canParse)
{
	switch (userInput)
	{
		case 1:
            Console.WriteLine(Months.January);
			break;
        case 2:
            Console.WriteLine(Months.February);
            break;
        case 3:
            Console.WriteLine(Months.March);
            break;
        case 4:
            Console.WriteLine(Months.April);
            break;
        case 5:
            Console.WriteLine(Months.May);
            break;
        case 6:
            Console.WriteLine(Months.June);
            break;
        case 7:
            Console.WriteLine(Months.July);
            break;
        case 8:
            Console.WriteLine(Months.August);
            break;
        case 9:
            Console.WriteLine(Months.September);
            break;
        case 10:
            Console.WriteLine(Months.October);
            break;
        case 11:
            Console.WriteLine(Months.November);
            break;
        case 12:
            Console.WriteLine(Months.December);
            break;
        default:
            Console.WriteLine("Error, incorrect value");
            break;
	}
}
else
{
    Console.WriteLine("Error, incorrect value");
}