using Class07_Demo.Models;

namespace Class07_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the default (empty) constructor
            //Car car1 = new Car()
            //{
            //    Color = "Red",
            //    FrameNumber = "A123123213",
            //    FuelType = "Petrol",
            //    HasParkingCameras = false,
            //    Model = "Renault",
            //    NumberOfSeats = 5,
            //    YearOfProduction = 2015
            //};

            //Console.WriteLine(car1.GetInfo());

            Bus bus = new Bus();
            bus.FrameNumber = "B123213213";
            bus.NumberOfSeats = 55;
            bus.NumberOfFloors = 1;
            bus.LicenseType = "License Type 1";
            bus.Model = "Vanhol";
            bus.Color = "White";

            Console.WriteLine(bus.GetInfo());

            Car car = new Car(2020, true, "Diesel", "Peugeot", 5, "White", "ADSDSDDq34242");
            Console.WriteLine(car.GetInfo());

            Vehicle v = new Vehicle("Tesla", 5, "Blue", "asdsadsadsa");
            Console.WriteLine(v.GetInfo());
        }
    }
}