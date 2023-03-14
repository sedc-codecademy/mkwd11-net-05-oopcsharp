namespace SEDC.OOPClasses
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Age} years old!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object and assign value to its properties
            Person martin = new Person();
            martin.FirstName = "Martin";
            martin.LastName = "Panovski";
            martin.Age = 29;

            Console.WriteLine(martin.FirstName);

            martin.GetInfo();
        }
    }
}