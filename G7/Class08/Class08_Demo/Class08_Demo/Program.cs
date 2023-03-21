namespace Class08_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary 
            // { ["0701234567", "Risto"], ["071123123123", "Tijana"]}
            Dictionary<long, string> people = new Dictionary<long, string>();
            Dictionary<int, Student> students = new Dictionary<int, Student>();


            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook.Add("+38970123456", "Risto");
            phoneBook.Add("070123433", "Tijana");
            //phoneBook.Add("+38970123456", "Marko");

            Student s1 = new Student() { FirstName = "Risto", LastName = "Panchevski" };
            students.Add(1001, s1);

            Student s2 = new Student() { FirstName = "test", LastName = "test" };
            students.Add(1002, s2);

            string name = phoneBook["070123433"];

            Student s2Value = students[1002];

            foreach (KeyValuePair<string, string> e in phoneBook)
            {
                Console.WriteLine($"{e.Value} - {e.Key}");
            }

            foreach (KeyValuePair<int, Student> e in students)
            {
                //Console.WriteLine($"{e.Key} - {e.Value.FirstName} {e.Value.LastName}");
                Console.WriteLine($"{e.Key} - {e.Value.GetFullName()}");
            }

            //string n = phoneBook["13123213"]; => throws an error because the key does not exist

            bool keyExist = phoneBook.ContainsKey("13123213");

            if (keyExist)
            {
                string n = phoneBook["13123213"];
            }

            bool valueExist = phoneBook.ContainsValue("Risto");

            Dictionary<string, int> plClubs = new Dictionary<string, int>()
            {
                { "Arsenal", 0},
                { "Man City", 0},
                { "Man Utd", 0}
            };

            Console.WriteLine($"{plClubs.Count}");
            plClubs.Remove("Man City");
            Console.WriteLine($"{plClubs.Count}");
            bool successAdd = plClubs.TryAdd("Arsenal", 0);
            bool successAdd1 = plClubs.TryAdd("Chelsea", 0);
            #endregion

            #region List
            List<string> animals = new List<string>();
            animals.Add("Cat");
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Tiger");

            List<int> evenNumbers = new List<int>() { 2, 4, 6, 8, 10, 12 };
            Console.WriteLine(evenNumbers[2]);
            evenNumbers[3] = 14;

            //Console.WriteLine(evenNumbers[8]); => will throw an error because element on that index does not exist

            evenNumbers.Add(16);
            evenNumbers.Add(18);
            evenNumbers.Add(20);

            bool exist = evenNumbers.Contains(12);
            //evenNumbers.RemoveAt(4);
            //evenNumbers.RemoveRange(2, 3);

            bool successfulRemove = evenNumbers.Remove(12);

            Console.WriteLine(evenNumbers.Count);

            List<Student> studentList = new List<Student>();

            studentList.Add(new Student()
            {
                FirstName = "1",
                LastName = "1"
            });

            studentList.Add(new Student()
            {
                FirstName = "2",
                LastName = "2"
            });

            foreach(Student s in studentList)
            {
                Console.WriteLine(s.GetFullName());
            }

            List<Student> studentList1 = new List<Student>();

            studentList1.Add(new Student()
            {
                FirstName = "3",
                LastName = "3"
            });

            studentList1.Add(new Student()
            {
                FirstName = "4",
                LastName = "4"
            });

            foreach (Student s in studentList1)
            {
                Console.WriteLine(s.GetFullName());
            }

            studentList1.AddRange(studentList);
            Console.WriteLine("---After merging---");
            foreach (Student s in studentList1)
            {
                Console.WriteLine(s.GetFullName());
            }

            List<List<string>> groups = new List<List<string>>()
            {
                new List<string> { "Student1 G1", "Student2 G1" , "Student3 G1" , "Student4 G1" },

                new List<string> { "Student1 G2", "Student2 G2" , "Student3 G2" , "Student4 G2" }
            };

            foreach(List<string> group in groups)
            {
                Console.WriteLine("-------------------------");
                foreach(string student in group)
                {
                    Console.WriteLine(student);
                }
            }
            #endregion

            #region Queue (FIFO)

            Queue<decimal> decimals = new Queue<decimal>();

            decimals.Enqueue(11.1M);
            decimals.Enqueue(22.2M);
            decimals.Enqueue(33.3M);
            decimals.Enqueue(44.4M);
            decimals.Enqueue(55.5M);
            decimals.Enqueue(66.6M);

            decimal d1 = decimals.Dequeue();
            decimal d2 = decimals.Dequeue();
            decimal d3 = decimals.Dequeue();
            //decimal d4 = decimals.Dequeue();

            bool successDequeue = decimals.TryDequeue(out decimal d4);

            decimal d5 = decimals.Peek();
            bool successPeek = decimals.TryPeek(out decimal d55);

            #endregion

            #region Stack (LIFO)
            Stack<string> cars = new Stack<string>();

            cars.Push("BMW");
            cars.Push("Renault");
            cars.Push("Tesla");
            cars.Push("Peugeot");
            cars.Push("Mercedes");

            string c1 = cars.Pop();
            string c2 = cars.Pop();
            string c3 = cars.Pop();

            bool successCarReturn = cars.TryPop(out string c4);

            string c5 = cars.Peek();
            bool successPeekCar = cars.TryPeek(out string car5);
            #endregion
        }
    }
}