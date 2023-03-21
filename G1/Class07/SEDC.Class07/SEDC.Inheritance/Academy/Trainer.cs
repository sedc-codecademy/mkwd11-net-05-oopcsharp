
namespace SEDC.Inheritance.Academy
{
    public class Trainer : Person
    {
        public int YearsOfExperience { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Hello I am {FirstName} and I work as a Trainer!");
        }
    }
}
