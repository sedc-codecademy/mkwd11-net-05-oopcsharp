namespace Class02_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo");

            string stringNumber = "12";
            string invalidStringNumber = "A";
            string zeroStringNumber = "0";

            int number = int.Parse(stringNumber);

            Console.WriteLine(number);

            //int invalidNumber = int.Parse(invalidStringNumber);

            int numberConvert = Convert.ToInt32(stringNumber);

            //int invalidNumber = Convert.ToInt32(invalidStringNumber);

            //int invalidNumber = int.Parse(null);
            int invalidNumber = Convert.ToInt32(null);

            int numberTryParse;

            //Trying to parse stringNumber, if it succeed it will return True as a result that will be stored in successfulParsing,
            //and the parsed value that will be stored in numberTryParse

            //bool successfulParsing = int.TryParse(stringNumber, out numberTryParse);
            //bool successfulParsing = int.TryParse(invalidStringNumber, out numberTryParse);
            bool successfulParsing = int.TryParse(zeroStringNumber, out numberTryParse);


            //Example
            Console.WriteLine("How many workout do you have per week?");
            string input = Console.ReadLine();

            int numberOfWorkouts;

            bool success = int.TryParse(input, out numberOfWorkouts);

            if (success)
            {
                //if user has more than 2 workouts per week we should print Great, you are active. If not you should workout more.
                if (numberOfWorkouts > 2)
                {
                    Console.WriteLine("Great, you are active.");
                }
                else
                {
                    Console.WriteLine("You should workout more.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            //Console.WriteLine("How many workout do you have per week?");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int numberOfWorkouts))
            //{
            //    //if user has more than 2 workouts per week we should print Great, you are active. If not you should workout more.
            //    if (numberOfWorkouts > 2)
            //    {
            //        Console.WriteLine("Great, you are active.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You should workout more.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input!");
            //}

            bool flag = true;

            if(flag)
            {
                //Logic when the flag is true
            } else
            {
                //Logic when the flag is false
            }

            if (flag)
                Console.WriteLine("It is true");
            else
                Console.WriteLine("It is false");


            if (flag)
            {
                Console.WriteLine("It is true");
            }
            else
            {
                Console.WriteLine("It is false");
            }

            int day = 5;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Mon");
                    break;
                case 2:
                    Console.WriteLine("Tus");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thu");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;
                default:
                    Console.WriteLine("Input is not a date, enter 1-7");
                    break;
            };
        }
    }
}