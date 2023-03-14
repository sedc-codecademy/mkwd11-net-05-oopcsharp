namespace SEDC.Class06.InfiniteLoops
{
    public class ParseInputs
    {
        public double ParseInputToDouble()
        {
            while(true)
            {
                Console.WriteLine("Please enter a number");
                string input = Console.ReadLine();

                bool isValidInput = 
                    double.TryParse(input, out double result);

                if(isValidInput)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Please enter valid number");
                }
            }
        }

        public bool ConfirmSelection()
        {
            while(true)
            {
                Console.WriteLine
                    ("Do you want to continue using this app.Enter Y for yes and N for no");
                string answer = Console.ReadLine();

                if(answer.ToLower() == "y")
                {
                    return true;
                }
                else if(answer.ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Plase enter valid input");
                }
            
            }
        }
    }
}
