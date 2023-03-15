namespace Exercise04.ATM.ConsoleApp.Classes
{
    public class Customer
    {
        public Customer(string firstname, string lastname, Card creditCard)
        {
            Firstname = firstname;
            Lastname = lastname;
            Card = creditCard;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Card Card { get; set; }

        public void GetCustomerInfo()
        {
            Console.WriteLine($"[{Firstname} {Lastname}]: Number: {Card.Number} PIN: {Card.GetCardPin()}");
        }
    }
}
