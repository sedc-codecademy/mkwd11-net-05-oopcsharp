namespace Exercise04.ATM.ConsoleApp.Classes
{
    public class Card
    {
        public Card(long cNumber, int balance)
        {
            Number = cNumber;
            Balance = balance;
            Pin = GeneratePin();
        }

        public long Number { get; set; }
        public int Balance { get; set; }
        private int Pin { get; set; }

        private int GeneratePin()
        {
            return new Random().Next(1000, 9999);
        }

        public int GetCardPin()
        {
            return Pin;
        }
    }
}
