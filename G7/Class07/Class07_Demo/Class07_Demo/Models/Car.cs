namespace Class07_Demo.Models
{
    public class Car : Vehicle
    {
        public int YearOfProduction { get; set; }
        public bool HasParkingCameras { get; set; }
        public string FuelType { get; set; }

        public Car(int yearOfProduction, bool hasParkingCameras, string fuelType, string model, int numberOfSeats, string color, string frameNumber)
            : base(model, numberOfSeats, color, frameNumber)
        {
            YearOfProduction = yearOfProduction;
            HasParkingCameras = hasParkingCameras;
            FuelType = fuelType;
        }

        public override string GetInfo()
        {
            //return $"This is a car: {Model}, {FrameNumber}, {FuelType}"; //completly new behaviour from the Parent class

            return $"Car: {base.GetInfo()}, {FuelType}, {HasParkingCameras}, {YearOfProduction}";
        }
    }
}
