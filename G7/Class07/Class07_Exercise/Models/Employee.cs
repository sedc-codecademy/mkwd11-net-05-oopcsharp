using System.Globalization;

namespace Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, RoleEnum role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        //public Employee() { }

        public string GetInfo()
        {
            return $"{FirstName} {LastName} - {GetSalary().ToString("C", new CultureInfo("en-US"))}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}