namespace SEDC.Class06.InfiniteLoops
{
    public class NumberDetails
    {
        public double Number { get; set; }

        public bool IsEven { get; set; }

        public bool IsPositive { get; set; }

        public bool IsDecimal { get; set; }

        public string GetNumberInfo()
        {
            // The number 25 is Odd, Positive and Integer
            string numberStats =
                string.Format(
                    "The number {0} is {1}, {2} and {3}",
                    Number,
                    IsEven ? "Even" : "Odd",
                    IsPositive ? "Positive" : "Negative",
                    IsDecimal ? "Decimal" : "Integer");
            return numberStats;
        }
    }
}
