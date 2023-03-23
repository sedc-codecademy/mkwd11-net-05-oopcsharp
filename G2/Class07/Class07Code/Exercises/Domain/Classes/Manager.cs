using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }
        public Manager(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = RoleEnum.Manager;
        }
        public void AddBonus(double bonus)
        {
            _bonus = bonus; 
        }
        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
