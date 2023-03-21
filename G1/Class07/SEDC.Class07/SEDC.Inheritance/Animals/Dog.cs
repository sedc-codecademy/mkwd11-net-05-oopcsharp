namespace SEDC.Inheritance.Animals
{
    public class Dog : Animal
    {
        // This 'Breed' property is specific ONLY for the Dog class
        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }

        //public void GetDogInfo()
        //{
        //    Console.WriteLine($"Hello, I am {Name}, and I am {YearsOld} years old!");
        //}

        public override void GetInfo()
        {
            Console.WriteLine($"Hello, I am {Name}, I am a dog and I am {YearsOld} years old!");
        }
    }
}
