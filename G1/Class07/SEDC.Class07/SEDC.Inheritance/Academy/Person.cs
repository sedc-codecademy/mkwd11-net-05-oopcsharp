namespace SEDC.Inheritance.Academy
{
    public class Person
    {
        public Person()
        {
            
        }

        public Person(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Roles Role { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("I come from person");
        }
    }
}
