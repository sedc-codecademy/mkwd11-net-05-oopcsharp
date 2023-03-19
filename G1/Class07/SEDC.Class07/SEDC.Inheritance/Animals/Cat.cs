namespace SEDC.Inheritance.Animals
{
    public class Cat : Animal
    {
        public string FavouriteFood { get; set; }

        public void Play()
        {
            Console.WriteLine("The cat is playing. Meow!");
        }


        //public void GetCatInfo()
        //{
        //    Console.WriteLine($"Hello, I am {Name}, and I am {YearsOld} years old!");
        //}

        public override void GetInfo()
        {
            Console.WriteLine($"Hello, I am {Name}, I am a cat and I am {YearsOld} years old!");
        }
    }
}
