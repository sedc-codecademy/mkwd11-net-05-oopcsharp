

namespace Inheritance.Models
{
    public class Cat : Animal
    {
        //gets the public and protected properties and methods from Animal
        public bool IsLazy { get; set; }

        //specific only for Cat class
        public void PrintAge()
        {
            //we can use Age because it is protected in the Animal class and it is inherited
            //we can't access Id because it is private in the Animal class
            //Console.WriteLine($"The cat with Id {Id} is {Age} years old"); -> ERROR

            Console.WriteLine($"The cat is {Age} years old");
        }

        //first call the default constructor from the base class (Animal), then execute the
        //default constructor of the Cat class
        public Cat() : base()
        {
            Console.WriteLine("Calling default Cat constructor");
        }

        //public void PrintIdentifierForCat()
        //{
        //    Console.WriteLine($"Identifier for cat: {Identifier}");
        //}

        //OVERRIDING METHODS
        public override void PrintIdentifier()
        {
            Console.WriteLine($"Identifier for cat: {Identifier}");
        }
    }
}
