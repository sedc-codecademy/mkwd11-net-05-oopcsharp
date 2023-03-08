namespace Class03_Exercise06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];

            while(true)
            {
                Console.WriteLine("Please enter a name");
                string input = Console.ReadLine();

                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = input;

                Console.WriteLine("If you want to add another name press Y/y, else press something");
                string inputCheck = Console.ReadLine();

                //if(inputCheck == "Y" || inputCheck == "y")
                //{
                //    continue;
                //} else
                //{
                //    break;
                //}

                if (inputCheck != "Y" && inputCheck != "y")
                {
                    break;
                }
            }

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}