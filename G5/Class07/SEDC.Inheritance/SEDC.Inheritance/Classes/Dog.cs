using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Inheritance.Classes
{
    public class Dog : Animal
    {
        // A property unique to Dog class. It also has all Animal properties ( Id, Name, Type )
        public string Race { get; set; }

        // A method unique to Dog
        public void Bark()
        {
            Console.WriteLine("Bark....");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"ID: {ID} Type: {Type}  Name: {Name} Race: {Race}");
        }

        // Constructor of cat that selects which constructor it will call first from parent with the base () 
        // This will call the constructor that takes a string from Animal, and then the Dog() constructor
        // This will not execute the default constructor in Animal
        public Dog() : base("Dog")
        {
            Console.WriteLine("A new instance of a Dog class");
        }
        //public Dog()
        //{
        //    Type = "Dog";
        //}
    }
}
