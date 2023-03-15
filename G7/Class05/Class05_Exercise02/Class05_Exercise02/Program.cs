namespace Class05_Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog's name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter dog's breed");
            string breed = Console.ReadLine();

            Console.WriteLine("Enter dog's color");
            string color = Console.ReadLine();

            Dog dog = new Dog(name, breed, color);

            Console.WriteLine("Insert number 1-3");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.WriteLine(dog.Eat());
                    break;
                case "2":
                    Console.WriteLine(dog.Play());
                    break;
                case "3":
                    Console.WriteLine(dog.ChaseTail());
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}