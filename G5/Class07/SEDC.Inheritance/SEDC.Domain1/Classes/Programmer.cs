using SEDC.Domain1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Domain1.Classes
{
    public class Programmer : Human
    {
        public string[] ProgrammerLanguages { get; set; }
        public ProgrammerTitle Title { get; set; }

        public void GetListProgrammerLanguages()
        {
            Console.WriteLine($"FullName: {FullName}");
            Console.WriteLine($"Programming languages:");
            foreach (string lang in ProgrammerLanguages)
            {
                Console.WriteLine(lang);
            }
        }

        public void GetInformationProgrammer()
        {
            Console.WriteLine($" ID: {ID} FullName: {FullName} Age: {Age} Title: {Title} developer");
        }

        public override void GetInfo()
        {
            Console.WriteLine($"FullName: {FullName} Age: {Age} Title: {Title} developer");

        }

    }
}
