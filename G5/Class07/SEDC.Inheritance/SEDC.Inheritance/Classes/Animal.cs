using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Inheritance.Classes
{
    public class Animal 
    {
        // These properties will be shared with all classes that inherit from this one
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        // Eet method that all classes that inherit from this one can call
        // We write virtual if we want this method to be overriden by child classes
        public virtual void PrintInfo()
        {
            Console.WriteLine($"ID: {ID} Type: {Type}  Name: {Name}");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }


        // Default constructor of animal. It will be called when new instance of Animal is created
        // It will also be called when new instance of any other child class is created
        // The parent constructor always executes first
        public Animal()
        {
            Console.WriteLine("A new instance of animal");
        }

        // Another constructor that takes a string as parameter
        public Animal(string type)
        {
            Type = type;
        }
        public Animal(int iD, string name, string type)
        {
            ID = iD;
            Name = name;
            Type = type;
        }
    }
}
