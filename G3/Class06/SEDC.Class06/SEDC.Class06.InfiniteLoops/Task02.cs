namespace SEDC.Class06.InfiniteLoops
{
    public class Task02
    {
        public void Run()
        {
            ParseInputs parsers = new ParseInputs();

            bool isAppActive = true;
            while(isAppActive)
            {
                 double number = 
                    parsers.ParseInputToDouble();

                NumberDetailsSecond details =
                    new NumberDetailsSecond(number);
                Console.WriteLine(details.GetNumberStats());

                isAppActive = parsers.ConfirmSelection();
            }
        }
    }
}
