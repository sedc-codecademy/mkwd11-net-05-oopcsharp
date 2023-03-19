

using EmployeeApp.Domain.Enums;

namespace EmployeeApp.Domain.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Role Role { get; set; }

        protected double Salary { get; set; }


        public Employee(string firstName, string lastName, Role role, double salary)
        {
            //TODO validation for values of firstName, lastName, salary
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} gets salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
