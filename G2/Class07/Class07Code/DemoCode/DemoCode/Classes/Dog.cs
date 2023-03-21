using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode.Classes
{
    // The child class Dog inherits from parent class Animal
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }
        public void PrintName()
        {
            Console.WriteLine($"{Name}"); //public
        }

        public void PrintId()
        {
            Console.WriteLine($"{Id}"); //protected
        }

        //public void PrintPrivateProperty()
        //{
        //    Console.WriteLine($"{_privateProperty}"); // not allowes -> private
        //}

        public Dog()
        {
            Console.WriteLine("Dog's parameterless constructor");
        }

        public void Eat()
        {
            Console.WriteLine("The dogs love to eat");
        }
        public override void Eat(string food)
        {
            //base.Eat(food); -> Animal.Eat
            Console.WriteLine($"The dog {Name} eats {food}");
        }

        public Dog(string name, string color, string breed) : base(name, color)
        {
            Breed = breed;
            Console.WriteLine("Dog's constructor with parameters was called!");
        }
    }
}
