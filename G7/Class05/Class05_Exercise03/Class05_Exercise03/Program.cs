namespace Class05_Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Test 1", "Programming", "G7");
            Student s2 = new Student("Test 2", "QA", "G3");
            Student s3 = new Student("Test 3", "Programming", "G5");
            Student s4 = new Student("Test 4", "Networking", "G1");
            Student s5 = new Student("Test 5", "Design", "G1");
            Student s6 = new Student("Test 3", "Programming", "G8");

            Student[] students = new Student[6] { s1, s2, s3, s4, s5, s6 };

            Console.WriteLine("Please write the name of the student:");
            string input = Console.ReadLine();

            bool studentFound = false;

            for(int i = 0; i < students.Length; i++)
            {
                if (students[i].Name == input)
                {
                    Console.WriteLine($"We have found student: {students[i].Name} that matches the search");
                    studentFound = true;
                }
            }

            
        }
    }
}