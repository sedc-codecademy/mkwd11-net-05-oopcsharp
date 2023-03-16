using SEDC.Domain1.Classes;
using SEDC.Domain1.Enums;

Human human = new Human() { FullName = "Angel Mitrov", Age = 21, Gender = Gender.Men};

human.GetInfo();

Programmer programmer = new Programmer() {FullName = "maj d-r Mitko Veljusliev", Age = 40, Gender = Gender.Men, Title = ProgrammerTitle.Junior, ProgrammerLanguages = new string[] { "Javascript", "HTML", "CSS", "C#" } };

programmer.GetInfo();
programmer.GetListProgrammerLanguages();
programmer.GetInformationProgrammer();