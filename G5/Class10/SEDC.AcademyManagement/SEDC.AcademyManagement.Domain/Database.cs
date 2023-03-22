using SEDC.AcademyManagement.Domain.Models;

namespace SEDC.AcademyManagement.Domain
{
    public class Database
    {

        public Database()
        {
            SeedData();
        }

        public List<Admin> Admins { get; set; } = new List<Admin>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();


        private void SeedData()
        {

            Subjects = new List<Subject>()
            {
                new Subject("HTML"),
                new Subject("Basic Js"),
                new Subject("Advance Js"),
                new Subject("Basic C#"),
            };

            Admins = new List<Admin>()
            {
                new Admin("codeacademy1", "SEDC", "Admin 1", 25),
                new Admin("codeacademy2", "SEDC", "Admin 2", 25),
            };

            Trainers = new List<Trainer>()
            {
                new Trainer("amitrov", "Angel", "Mitrov", 21),
                new Trainer("dborozan", "Danilo", "Borozan", 25)
            };

            Students = new List<Student>()
            {
                new Student("akarajov", "Mice", "Karajov", 20),
                new Student("mcipusheva", "Marija", "Cipusheva", 20),
                new Student("signova","Sanja", "Ignova", 20),
                new Student("mkacakov", "Mario", "Kacakov", 20),
                new Student("dtodoroski", "Dragisa", "Todoroski", 20),
                new Student("egjorgieva", "Eleonora", "Gjorgieva", 20),
                new Student("skozoloski", "Simon", "Kozoloski", 20),
                new Student("tkozoloski", "Tomo", "Kozoloski", 20),
                new Student("tristovska","Tatjana", "Ristovska", 20),
                new Student("ljoldasev", "Ljubomir", "Joldasev", 20),
                new Student("nstamenkovski", "Nikola", "Stamenkovski", 20),
                new Student("vnaumovski", "Vasilij", "Naumovski", 20),
                new Student("mveljusliev", "Mitko", "Veljusliev", 20),
                new Student("mstrezoski", "Martin", "Strezoski", 20),
                new Student("dmilkovski", "Dimitar", "Milkovski", 20),
                new Student("dbogdanov", "Dimitar", "Bogdanov", 20),
                new Student("iskojkovskapetrovska", "Irena", "Skojkovska Petrovska", 20),
                new Student("dpetrovski", "Dimitar", "Petrovski", 20),
                new Student("dtemelkovski", "Dejan", "Temelkovski", 20),
            };

            foreach (Student student in Students)
            {
                foreach (Subject subject in Subjects)
                {
                    student.Grades.Add(subject, new Random().Next(1, 6));
                    student.CurrentSubject = subject;
                }
            }

            Students[1].CurrentSubject = null;
            Students[1].Grades = null;

            Students[5].CurrentSubject = null;
            Students[5].Grades = null;

            Students[10].CurrentSubject = null;
            Students[10].Grades = null;

            Students[15].CurrentSubject = null;
            Students[15].Grades = null;

            Students.ForEach(x => x.PrintDetails());

            Console.WriteLine();
            Console.WriteLine("Seeding finished ...");
            Console.WriteLine();

        }
    }
}
