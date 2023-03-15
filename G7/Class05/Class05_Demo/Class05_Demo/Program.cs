using System.Text;

namespace Class05_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            User user1 = new User();

            Console.WriteLine("Hello, to our bank!");

            BankAccount account1 = new BankAccount();
            account1.FirstName = "Risto";
            account1.LastName = "Panchevski";
            account1.AccountNumber = 12345678987654;
            account1.Id = "A00010101";

            int amount = 1000;
            account1.Deposit(amount);

            account1.Deposit(500);
            account1.Deposit(200);

            account1.Withdraw(400);
            account1.Withdraw(2000);

            BankAccount account2 = new BankAccount("Test", "Test", "A00000", 213123123123);
        }
    }
}