namespace Exercises.Exercise4.Classes
{

    public class Customer
    {
        public Customer(string first, string last, int balance)
        {
            FirstName = first;
            LastName = last;
            Card = new Card(balance);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Card Card { get; set; }


        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - Card Number: {Card.CardNumber}   PIN: {Card.GetPin()}");
        }
    }
}
