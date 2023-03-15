using SEDC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Domain.Classes
{
    public class Programmer : Human
    {
        public string[] ProgrammingLanguages { get; set; }
        public ProgrammingTitle Title { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"This is {FirstName} {LastName} and I am {Title} developer. These are the programming langueages they know:");
            foreach(string language in ProgrammingLanguages)
            {
                Console.WriteLine(language);
            }
        }


    }
}
