namespace Class02_Exercise05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 05");

            //input => trees
            //input => apples
            //input => number of apples per basket

            Console.WriteLine("How many trees you have?");
            string treesInput = Console.ReadLine();

            int treesNumber;

            bool treesNumberSuccess = int.TryParse(treesInput, out treesNumber);

            if(!treesNumberSuccess)
            {
                Console.WriteLine("Wrong input!");
                return;
            }


            //input => branches
            Console.WriteLine("How many branches are per tree?");

            if(!int.TryParse(Console.ReadLine(), out int branchNumber))
            {
                Console.WriteLine("Wrong input!");
                return;
            }

            //input => apples
            Console.WriteLine("How many apples are per branch?");
            string applesInput = Console.ReadLine();

            int appleNumber;

            bool appleNumberSuccess = int.TryParse(applesInput, out appleNumber);

            if (!appleNumberSuccess)
            {
                Console.WriteLine("Wrong input!");
                return;
            }


            //input => apples per bucket
            Console.WriteLine("How many apples are per bucket?");

            if (!int.TryParse(Console.ReadLine(), out int applesPerBucketNumber))
            {
                Console.WriteLine("Wrong input!");
                return;
            }

            //Console.WriteLine($"{treesNumber}, {branchNumber}, {appleNumber}, {applesPerBucketNumber}");

            int applesTotal = treesNumber * branchNumber * appleNumber;
            int numberOfBuckets = applesTotal / applesPerBucketNumber;

            //modules operation is used to identify whether we have some leftover apples that will be added in additional bucket which not be completly full.
            if(applesTotal % applesPerBucketNumber > 0)
            {
                numberOfBuckets = numberOfBuckets + 1;
                //numberOfBuckets += 1;
                //numberOfBuckets++;
                //++numberOfBuckets;
            }

            Console.WriteLine($"You need: {numberOfBuckets} buckets");
        }
    }
}