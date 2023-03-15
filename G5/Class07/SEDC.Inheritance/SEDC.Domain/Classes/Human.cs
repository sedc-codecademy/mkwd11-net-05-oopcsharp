using SEDC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Domain.Classes
{
    public class Human
    {
        private int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Id: {ID} FullName: {FirstName} {LastName} Age: {Age} Gender: {Gender}");
        }

        public Human()
        {
            Console.WriteLine("A new instance of an human class");
        }
    }
}
