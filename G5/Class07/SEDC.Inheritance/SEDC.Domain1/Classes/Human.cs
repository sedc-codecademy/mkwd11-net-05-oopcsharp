using SEDC.Domain1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Domain1.Classes
{
    public class Human
    {
        protected int ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($" ID: {ID} FullName: {FullName} Age: {Age} Gender: {Gender}");
        }

        public Human()
        {
            Console.WriteLine("Create a new instance for human");
        }


    }
}
