namespace SEDC.Inheritance.Animals
{
    public class Animal
    {
        public Animal()
        {
            
        }

        public Animal(string name, string color, int yearsOld)
        {
            Name = name;
            Color = color;
            YearsOld = yearsOld;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int YearsOld { get; set; }

        //public void GetInfo()
        //{
        //    Console.WriteLine($"Hello I am an animal!");
        //}

        public virtual void GetInfo()
        {
            Console.WriteLine($"Hello I am an animal!");
        }
    }
}
