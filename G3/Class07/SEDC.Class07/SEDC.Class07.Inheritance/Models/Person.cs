using System.Xml.Serialization;

namespace SEDC.Class07.Inheritance.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime CreatedOn { get; set; }

        // this will  be only available in Person class
        private DateTime DateOfBirth { get; set; }

        public Person()
        {
            Console.WriteLine("default Person ctor");
            CreatedOn = DateTime.Now;
            DateOfBirth = DateTime.Now.AddYears(-22);
        }

        public Person(int id, string firstName, string lastName)
        {
            Console.WriteLine("Person ctor");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreatedOn = DateTime.Now;
            DateOfBirth = DateTime.Now.AddYears(-22);
        }
    
        public virtual void PrintInfo()
        {
            Console.WriteLine("Print info Person");
            string info = string.Format(
                "Id: {0} person: {1} {2}",
                Id, FirstName, LastName);
            Console.WriteLine(info);
        }

        protected DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }
    }
}
