using SEDC.AcademyManagement.Domain.Enums;
using System;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class Student : User
    {
        public Student(string username, string firstname, string lastname, int age) : base(username, firstname, lastname, age)
        {
            Role = Role.Student;
        }

        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject, int> Grades { get; set; } = new Dictionary<Subject, int>();

        public void PrintDetails()
        {
            Console.WriteLine($"[{Age}] {Firstname} {Lastname} ({Username})");

            if (CurrentSubject == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Currently on holiday");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Currently attending {CurrentSubject.Name}");
                Console.ResetColor();
            }


            Console.WriteLine();
            Console.WriteLine("Grades");

            if (Grades == null || Grades.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The student has no grades!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (var grade in Grades)
                {
                    Console.WriteLine($"{grade.Key.Name}: {grade.Value}");
                }
                Console.ResetColor();
            }
            Console.WriteLine("==========================");
        }
    }
}
