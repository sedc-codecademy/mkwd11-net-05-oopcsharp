namespace SEDC.Class07.Inheritance.Models
{
    public class Student : Person
    {
        public string Academy { get; set; }
        public string CurrentSubject { get; set; }
        public string[] FinishedSubjects { get; set; }
    }
}
