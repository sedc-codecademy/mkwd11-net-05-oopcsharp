using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private int _ssn { get; set; }
        public Person()
        {
            _ssn = GenerateSSN();
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _ssn = GenerateSSN();
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            _ssn = GenerateSSN();
        }

        public string GetDescription()
        {
            return $"{FirstName} {LastName}, has {Age} years, with SSN: {_ssn}";
        }

        private int GenerateSSN()
        {
            return new Random().Next(100000, 999999);
        }
    }
}
