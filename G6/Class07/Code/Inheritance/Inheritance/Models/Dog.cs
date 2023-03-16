

namespace Inheritance.Models
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        //first call the default constructor from the base class (Animal), then execute the
        //default constructor of the Dog class

        //Always. when we call constructor from the inherited classes, the default constructor from the base class
        //is being called. Unless when we specify it in a different way;
        public Dog() //: base()  
        {
            Console.WriteLine("Calling default Dog constructor");
        }

        //public Dog(string name, string color) //DEFAULT CONSTRUCTOR FROM BASE CLASS WILL BE CALLED
        //{
        //    Name = name;
        //    Color = color;
        //}

        public Dog(string name, string color) : base("Dog")
        {
            Name = name;
            Color = color;
        }



        public override void PrintIdentifier()
        {
            Console.WriteLine($"Identifier for dog: {Identifier}");
        }
    }
}
