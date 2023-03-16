// See https://aka.ms/new-console-template for more information
using SEDC.Class07.Inheritance.Models;

Console.WriteLine("Hello, World!");

// default ctor
Trainer trainer = new Trainer()
{
    Academy = "Code",
    CreatedOn = DateTime.Now,
    FirstName = "Trajan",
    Id = 1,
    LastName = "Stevkovski",
    Salary = 100,
    Subjects = new string[] { "C#" }
};
trainer.PrintInfo();
// second ctor
Trainer trainer1 = 
    new Trainer(1, "Bob", "Bobski", "Network", 150);
trainer1.PrintInfo();
trainer1.GetAge();

Assistant assistant = new Assistant()
{
    Id = 1,
    LastName = "Manaskov",
    FirstName = "Dragan",
    CreatedOn = DateTime.Now,
    Academy = "Code",
    Courses = new string[] { "C#", "AJS", "BJS" }
};
assistant.PrintInfo();

Student student = new Student()
{
    Id = 1,
    Academy = "Code",
    CreatedOn = DateTime.Now,
    FirstName = "Student",
    LastName = "StudentLastName",
    CurrentSubject = "C# Basic",
    FinishedSubjects = new string[] { "AJS", "BJS" }
};
student.PrintInfo();