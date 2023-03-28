using Excercise01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01
{
    public class Person : Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private int _ssn { get; set; }
        public Occupation Occupation { get; set; }

        private int _monthlyWage { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public Person()
        {

        }
        public Person(string firstName, string lastName, int age, int ssn) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _ssn = ssn;
            Mobile = Mobile;
            Address = Address;
            State = State;
            Phone = Phone;
            Email = Email;
            Occupation = Occupation;
            
        }
        public void OccupationCheck(int age)
        {
            if (age < 16)
            {
                Console.WriteLine("Error under 16");
            }
            else if (age < 18)
            {
                Console.WriteLine(Occupation.Student);
            }
            else if ( age > 65) {
                Console.WriteLine(Occupation.Retired);
            }
            else
            {
                Console.WriteLine(Occupation.DataEngineer);
            }
        }
        public bool HasDepositProduct { get; set; }

        public void CheckCandidate()
        {
            bool isGoodCandidate;
            if (_monthlyWage > 18000 && Age > 25 && Age < 60)
            {
                isGoodCandidate = true;
            }
        }
        //public bool IsLoanCandidate()
        //{
        //    bool hasDeposit = false;
        //    foreach (var product in Products)
        //    {
        //        if (product == "")
        //        {
        //            hasDeposit = true;
        //            break;
        //        }
        //    }
        //    if (_monthlyWage > 18000 && Age > 25 && Age < 60 && hasDeposit)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public void generateSSN()
        {
            int random = new Random().Next(1000,9999);
            _ssn = (int)random;
        }
    }
}
