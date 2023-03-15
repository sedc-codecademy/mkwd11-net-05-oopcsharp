
using SEDC.Exercise.Car.Models;

void RaceCars(Car firstCar, Car secondCar)
{
    if (firstCar.CalculateSpeed(firstCar.Driver) > secondCar.CalculateSpeed(secondCar.Driver))
    {
        Console.WriteLine($"In the race the winner car was {firstCar.Model}. It was driving with {firstCar.Speed}km/h and the driver was {firstCar.Driver.Name}");
    }
    else if (firstCar.CalculateSpeed(firstCar.Driver) < secondCar.CalculateSpeed(secondCar.Driver))
    {
        Console.WriteLine($"In the race the winner car was {secondCar.Model}. It was driving with {secondCar.Speed}km/h and the driver was {secondCar.Driver.Name}");

    }
    else
    {
        Console.WriteLine("They are equal!");
    }
}


Driver d1 = new Driver("Martin", 3);
Driver d2 = new Driver("Antonio", 5);
Driver d3 = new Driver("Monika", 5);
Driver d4 = new Driver("Marija", 2);

Car c1 = new Car("Hyundai", 150);
Car c2 = new Car("Mazda", 120);
Car c3 = new Car("Ferrari", 220);
Car c4 = new Car("Porsche", 200);


Driver[] drivers = new Driver[] { d1, d2, d3, d4 };
Car[] cars = new Car[] { c1, c2, c3, c4 };
bool endGame = true;

do
{
    Console.WriteLine($"Please select the first car: \n1.{c1.Model}\n2.{c2.Model}\n3.{c3.Model}\n4.{c4.Model}");
    bool canParseFirstCar = int.TryParse(Console.ReadLine(), out int firstCarChoice);

    Console.WriteLine($"Please select the second car: \n1.{c1.Model}\n2.{c2.Model}\n3.{c3.Model}\n4.{c4.Model}");
    bool canParseSecondCar = int.TryParse(Console.ReadLine(), out int secondCarChoice);

    Console.WriteLine($"Please select the first driver: \n1.{d1.Name}\n2.{d2.Name}\n3.{d3.Name}\n4.{d4.Name}");
    bool canParseFirstDriver = int.TryParse(Console.ReadLine(), out int firstDriverChoice);

    Console.WriteLine($"Please select the second driver: \n1.{d1.Name}\n2.{d2.Name}\n3.{d3.Name}\n4.{d4.Name}");
    bool canParseSecondDriver = int.TryParse(Console.ReadLine(), out int secondDriverChoice);

    if (canParseFirstCar && canParseSecondCar && canParseFirstDriver && canParseSecondDriver)
    {
        Car firstSelectedCar = cars[firstCarChoice - 1];
        Car secondSelectedCar = cars[secondCarChoice - 1];

        Driver firstSelectedDriver = drivers[firstDriverChoice - 1];
        Driver secondSelectedDriver = drivers[secondDriverChoice - 1];

        firstSelectedCar.Driver = firstSelectedDriver;
        secondSelectedCar.Driver = secondSelectedDriver;

        RaceCars(firstSelectedCar, secondSelectedCar);

        Console.WriteLine("Do you want to play again! If not please enter n or N otherwise enter y or Y");
        string userInput = Console.ReadLine();
        if(userInput.ToLower() == "n")
        {
            endGame = false;
        }
    }
    else
    {
        Console.WriteLine("Wrong input! Please select using numbers from 1-4");
    }
} while (endGame);

