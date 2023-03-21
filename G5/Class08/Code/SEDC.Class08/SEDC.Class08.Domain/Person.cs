namespace SEDC.Class08.Domain
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"[{Age}] {Name}");
        }
    }
}
