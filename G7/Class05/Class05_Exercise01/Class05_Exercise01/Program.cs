namespace Class05_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            h1.FirstName = "Test";
            h1.LastName = "Test";
            h1.Age = 20;

            Human h2 = new Human()
            {
                FirstName = "Test 2",
                LastName = "Test 2",
                Age = 23
            };

            Human[] humans = new Human[3];

            humans[0] = h1;
            humans[1] = h2;

            Console.WriteLine("Please write your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please write your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please write your age:");
            int age = int.Parse(Console.ReadLine());

            Human h3 = new Human();
            h3.FirstName = name;
            h3.LastName = lastName;
            h3.Age = age;

            humans[2] = h3;

            foreach(Human h in humans)
            {
                Console.WriteLine(h.GetPersonStats());
            }
        }
    }
}