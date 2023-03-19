namespace Class07_Demo.Models
{
    public class Vehicle
    {
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public string FrameNumber { get; set; }

        public Vehicle(string model, int numberOfSeats, string color, string frameNumber)
        {
            Model = model;
            NumberOfSeats = numberOfSeats;
            Color = color;
            FrameNumber = frameNumber;
        }

        public Vehicle() { }

        public virtual string GetInfo()
        {
            return $"{Model} - {NumberOfSeats} seats - {Color} [{FrameNumber}]";
        }
    }
}
