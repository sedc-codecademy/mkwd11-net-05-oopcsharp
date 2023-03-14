using RetroExercise.Models;
using System.Globalization;

Student[] students = new Student[5];
//call the constructor with params from the Student class, to initialize objects
students[0] = new Student("Tanja", "Stojanovska", "Programming", "G2");
students[1] = new Student("Stefan", "Trajkov", "Programming", "G4");
students[2] = new Student("Bojan", "Damchevski", "QA", "G3");
students[3] = new Student("Jovana", "Jovanovska", "Networks", "G3");
students[4] = new Student("Nikola", "Nikolovski", "Design", "G7");

Console.WriteLine("Enter first name:");
string input = Console.ReadLine();

Student foundStudent = FindStudent(students, input);

if(foundStudent != null)
{
    Console.WriteLine("We found the student!");
}
else
{
    Console.WriteLine("Student was not found");
}

Student FindStudent(Student[] studentsArray, string firstName)
{
    foreach(Student student in studentsArray)
    {
        if(student.FirstName.ToLower() == firstName.ToLower())
        {
            return student; //stop the loop, exit the method
        }
    }

    return null;
}