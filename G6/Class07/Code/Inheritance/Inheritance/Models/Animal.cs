

namespace Inheritance.Models
{
    public class Animal
    {
        //The public properties are accessible in the inherited classes and in the code in general
       
        public string Name { get; set; }
        public string Type { get; set; }
        //Protected properties are only accessible in the class (Animal) and in the inherited classes (not in Program.cs)
        protected int Age { get; set; }

        //Id is only accessible in the Animal class, it is not inherited!!!
        private int Id { get; set; }

        protected int Identifier { get; set; }

        public Animal()
        {
            Identifier = new Random().Next(1, 10000);
            Console.WriteLine("Calling default Animal constructor");
        }

        public Animal(string type)
        {
            Type = type;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The animal with Id {Id} and Name {Name} is {Age} years old");
        }

        public virtual void PrintIdentifier()
        {
            Console.WriteLine($"Identifier: {Identifier}");
        }
    }
}
