// See https://aka.ms/new-console-template for more information
using SEDC.Class06.InfiniteLoops;

Console.WriteLine("Hello, World!");

// solution with classes
Task02 task02 = new Task02();
task02.Run();


// solutions with methods
//Task2Solution1();
//Task2Solution2();


void NumberStats(double number)
{
    NumberDetails details = new NumberDetails();
    details.Number = number;

    details.IsPositive = number > 0;
    details.IsEven = number % 2 == 0;
    details.IsDecimal = number % 1 != 0;

    Console.WriteLine(details.GetNumberInfo());
}

void Task2Solution1()
{
    while (true)
    {
        Console.WriteLine("Please enter a number");
        string number = Console.ReadLine();

        bool isValidNumber = double
            .TryParse(number, out double parseNumber);

        if (!isValidNumber)
        {
            Console.WriteLine(
                "Number is not valid! Please try again");
            continue;
        }

        NumberStats(parseNumber);

        Console.WriteLine(
            "Do you want to continue using this app? Press Y for yes N for no");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "n")
        {
            break;
        }
    }
}

void Task2Solution2()
{
    bool isAppActive = true;
    bool isActiveConfirmation = true;
    while (isAppActive)
    {
        Console.WriteLine("Please enter a number");
        string number = Console.ReadLine();

        bool isValidNumber = double
            .TryParse(number, out double parseNumber);

        if (!isValidNumber)
        {
            Console.WriteLine(
                "Number is not valid! Please try again");
            continue;
        }

        NumberStats(parseNumber);
        isActiveConfirmation = true;

        while(isActiveConfirmation)
        {
            Console.WriteLine(
                        "Do you want to continue using this app? Press Y for yes N for no");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "n")
            {
                isActiveConfirmation = false;
                isAppActive = false;
            } 
            else if(answer.ToLower() == "y")
            {
                isActiveConfirmation = false;
            } 
            else
            {
                Console.WriteLine("Please enter one of the following: Y for yes and N for no");
            }
        }
    }
}