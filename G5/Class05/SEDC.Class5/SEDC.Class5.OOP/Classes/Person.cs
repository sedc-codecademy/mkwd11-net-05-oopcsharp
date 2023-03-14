
namespace SEDC.Class5.OOP.Classes
{
    // Access Modifiers
    // public - you can access the objects from anywhere
    // private - you can only access the objects inside the Person class
    // internal - you can only access the objects inside the same project (SEDC.Class05.OOP)
    // protected - you can only access the objects inside the Person class or inside any class derived from this class
    public class Person
    {
        // Throws Error

        // We cannot create multiple constructors with same signature ( property types )
        // We already have parameterless constructor
        //public Person() { }

        // We already have constructor with string and int signature
        //public Person(string name, int age) { }

        // Parameterless Constructor
        // When we construct object from this constructor we are only going to populate PersonalNumber (this will populate from the private method)
        public Person()
        {
            PersonalNumber = GeneratePersonalNumber();
        }

        // Constructor with string and int signature
        // When we construct a object from this constructor we are going to populate Name and Age properties via the constructor
        // Balance of the constructed object initially is going to be set to 10 because we are hardcoding it as default value
        // PersonalNumber is going to be populated with random generated number from the private method below
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Balance = 10;
            PersonalNumber = GeneratePersonalNumber();
        }

        // All properties are going to populated from the constructor
        // Again PersonalNumber is going to be set from the private method
        public Person(string name, int age, double balance)
        {
            Name = name;
            Age = age;
            Balance = balance;
            PersonalNumber = GeneratePersonalNumber();
        }

        // Properties must have acces modifier, type and getter & setter
        public string Name { get; set; } = "Unnammed"; // Setting default value for Name
        public int Age { get; set; } = 1; // Setting default value for Age
        public double Balance { get; set; }
        private long PersonalNumber { get; set; } // Private properties can only be accessed inside the Person class


        public void Talk(string message)
        {
            Console.WriteLine($"[{PersonalNumber}] {Name} ({Age}) is saying: {message}");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"[{PersonalNumber}] {Name}'s Balance: {string.Format("{0:C}", Balance)}");
        }

        // BuyProduct expects parameter of type Product (Object constructed from the Product class)
        public void BuyProduct(Product product)
        {
            CheckBalance();
            // In this method we expect to get parameter of type Product, because of that we can access Product properties via that parameter
            if (Balance >= product.Price)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{Name} just bought {product.Name} for {string.Format("{0:C}", product.Price)}");
                Balance -= product.Price;
                Console.ResetColor();
                CheckBalance();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"You need {string.Format("{0:C}", product.Price - Balance)} to buy {product.Name}");
                Console.ResetColor();
            }

        }

        // Private methods can only be accessed inside the Person class
        private long GeneratePersonalNumber()
        {
            // Generates a random number between the values
            return new Random().Next(100000, 999999);
        }
    }
}
