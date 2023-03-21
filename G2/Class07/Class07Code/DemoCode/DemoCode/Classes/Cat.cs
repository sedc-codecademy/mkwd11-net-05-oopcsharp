using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode.Classes
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }
        //specific method for Cat
        public void Talk()
        {
            Console.WriteLine($"The cat {Name} is talking");
        }
        //We override the default constructor
        //The default constructor of the base class will be called
        public Cat()
        {
            Console.WriteLine("Cats's parameterles constructor");
        }

        public override void Eat(string food)
        {
            // base.Eat(food); -> Animal.Eat
            Console.WriteLine($"The cat {Name} eats {food}");
        }
    }
}
