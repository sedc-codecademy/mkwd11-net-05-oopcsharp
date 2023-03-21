using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Inheritance.Academy
{
    public class Student : Person
    {
        public string[] Subjects { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Hello I am {FirstName} and I am a student");
        }
    }
}
