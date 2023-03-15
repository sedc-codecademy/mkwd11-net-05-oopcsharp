namespace SEDC.Class07.Inheritance.Models
{
    public class Trainer : Person
    {
        public string Academy { get; set; }
        public string[] Subjects { get; set; }
        public int Salary { get; set; }

        public Trainer()
            : base()
        {
            Console.WriteLine("default Trainer ctor");
        }

        public Trainer(int id, string 
            fName, string lName, 
            string academy, int salary)
            : base(id, fName, lName)
        {
            Console.WriteLine("Trainer ctor");
            Academy = academy;
            Salary = salary;
            Subjects = new string[1];
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Trainer Print info");
            string info = 
                $"Id: {Id}, Name: {FirstName} {LastName} is Trainer at {Academy} academy";
            Console.WriteLine(info);
        }

        public void Teach()
        {
            Console.WriteLine("Teaching!");
        }

        public void GetAge()
        {
            DateTime dob = GetDateOfBirth();
            int age = DateTime.Now.Year - dob.Year;
            Console.WriteLine($"Age is {age} years old");
        }
    }
}
