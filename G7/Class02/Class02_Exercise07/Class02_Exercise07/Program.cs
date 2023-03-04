namespace Class02_Exercise07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number between 1-3");
            //string input = Console.ReadLine();

            //if(!int.TryParse(input, out int number))
            //{
            //    Console.WriteLine("Wrong number");
            //    return;
            //}

            //switch(number)
            //{
            //    case 1:
            //        Console.WriteLine("You won a car");
            //        break;
            //    case 2:
            //        Console.WriteLine("You won a plane");
            //        break;
            //    case 3:
            //        Console.WriteLine("You won a bike");
            //        break;
            //    default:
            //        Console.WriteLine("You need to enter number between 1 and 3");
            //        break;
            //}

            Console.WriteLine("Please enter a number between 1-3");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You won a car");
                    break;
                case "2":
                    Console.WriteLine("You won a plane");
                    break;
                case "3":
                    Console.WriteLine("You won a bike");
                    break;
                default:
                    Console.WriteLine("You need to enter number between 1 and 3");
                    break;
            }
        }
    }
}