namespace Class05_Demo
{
    public class BankAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public long AccountNumber { get; set; }
        private decimal Balance { get; set; }
        public string Info { get; set; }

        public BankAccount(string firstName, string lastName, string id, long accountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            AccountNumber = accountNumber;
            Balance = 0;
            Info = "Constructed from first constructor";
        }

        public BankAccount(string firstName, string lastName, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Balance = 0;
            Info = "Constructed from second constructor";
        }

        public BankAccount()
        {
            Balance = 0;
            Info = "Constructed from Default constructor";
        }

        public void Withdraw(int amount)
        {
            if(Balance < amount)
            {
                Console.WriteLine("Limit exceeded!");
                return;
            }

            Balance = Balance - amount;
            //Balance -= amount;
            Console.WriteLine($"You have successfuly withdrawn {amount:C} money");
        }

        public void Deposit(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("The amount for the deposit needs to be larger than 0");
                return;
            }

            Balance += amount;
            Console.WriteLine($"You have successfuly deposit {amount:C} money");
        }
    }
}
