namespace SEDC.Class05.ClassesAndObjects
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        // default constructor
        public Person()
        {
            SSN = GenerateSSN();
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            SSN = GenerateSSN();
        }

        public void Talk(string text)
        {
            Console.WriteLine(
                $"The human named {Name}(SSN:{SSN}) is saying: {text}");
        }

        private long GenerateSSN()
        {
            return new Random().Next(100000, 999999);
        }
    }
}
