namespace SEDC.Class06.InfiniteLoops
{
    public class NumberDetailsSecond
    {
        public double Number { get; set; }

        public NumberDetailsSecond(double number)
        {
            Number = number;
        }

        public string GetNumberStats()
        {
            // The number 25 is Odd, Positive and Integer
            string numberStats =
                string.Format(
                    "The number {0} is {1}, {2} and {3}",
                    Number,
                    IsEven() ? "Even" : "Odd",
                    IsPositive() ? "Positive" : "Negative",
                    IsDecimal() ? "Decimal" : "Integer");
            return numberStats;
        }

        public NumberDetails GetNumberDetails()
        {
            return new NumberDetails
            {
                Number = Number,
                IsDecimal = IsDecimal(),
                IsEven = IsEven(),
                IsPositive = IsPositive(),
            };
        }

        private bool IsEven()
        {
            return Math.Floor(Number) % 2 == 0;
        }

        private bool IsPositive()
        {
            return Number > 0;
        }

        private bool IsDecimal()
        {
            return Number % 1 != 0;
        }
    }
}
