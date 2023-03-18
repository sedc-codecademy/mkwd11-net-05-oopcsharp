using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }

        public Dog()
        {

        }
        public void Eat()
        {
            Console.WriteLine("The dog is now eating.");
        }
        public void Play()
        {
            Console.WriteLine("The dog is now playing");
        }
        public void ChaseTail()
        {
            Console.WriteLine("The dog is now chasing its tail!");
        }
        public void Command()
        {
            Console.WriteLine("Chose an activity for the dog: 1 - Play, 2 - Chase, 3 - Eat");
            int command = Convert.ToInt32(Console.ReadLine());
            switch (command)
            {
                case 1:
                   Play();
                    break;
                case 2:
                    ChaseTail();
                    break;
                case 3:
                    Eat();
                    break;
                default:
                    Console.WriteLine("The dog does not understand your command...");
                    break;
            } 
        }

    }
    
}
