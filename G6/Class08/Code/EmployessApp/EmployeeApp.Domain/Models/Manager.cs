

using EmployeeApp.Domain.Enums;

namespace EmployeeApp.Domain.Models
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }

        //public Manager(string firstName, string lastName, Role role, double salary, double bonus) : base(firstName, lastName, role, salary)
        //{
        //    _bonus = bonus;
        //}

        public Manager(string firstName, string lastName, Role role, double salary) : base(firstName, lastName, role, salary)
        {
            _bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            _bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
