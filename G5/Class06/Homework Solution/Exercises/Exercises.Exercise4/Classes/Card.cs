namespace Exercises.Exercise4.Classes
{
    public class Card
    {
        public Card(int balance)
        {
            Balance = balance;
            CardNumber = GenerateAccountNumber();
            Pin = GeneratePin();
        }

        public long CardNumber { get; set; }
        private short Pin { get; set; }
        private int Balance { get; set; }


        public bool CheckPin(short pin)
        {
            if (Pin == pin) return true;
            return false;
        }

        public int GetPin()
        {
            return Pin;
        }

        public void CheckBalance()
        {
            Console.WriteLine(string.Format("Your balance is: {0:C}", Balance));
        }

        public void Withdraw(int ammount)
        {

            if (ammount > Balance)
            {
                Console.WriteLine("You don't have enough money on your account!");
            }
            else
            {
                Console.WriteLine(string.Format("You withdrawed {0:C}", ammount));
                Balance -= ammount;
                CheckBalance();
            }
        }

        public void Deposit(int ammount)
        {
            Console.WriteLine(string.Format("You deposited {0:C}", ammount));
            Balance += ammount;
            CheckBalance();
        }


        private short GeneratePin()
        {
            return (short)new Random().Next(1000, 9999);
        }

        private long GenerateAccountNumber()
        {
            return new Random().NextInt64(1000000000000000, 9999999999999999);
        }
    }
}
