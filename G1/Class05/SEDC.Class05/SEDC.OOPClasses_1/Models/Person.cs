using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOPClasses_1.Models
{
    internal class Person
    {
        // Default constructor
        public Person()
        {
            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int Age { get; set; }

        private string PhoneNumber { get; set; }

        public void GetYearsOldInfo(DateTime birthDate)
        {
            if (DateTime.Now.Month < birthDate.Month)
            {
                Age = DateTime.Now.Year - birthDate.Year - 1;
            }
            else
            {
                Age = DateTime.Now.Year - birthDate.Year;
            }

            Console.WriteLine($"{FirstName} {LastName} is {Age} years old.");
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
    }
}
