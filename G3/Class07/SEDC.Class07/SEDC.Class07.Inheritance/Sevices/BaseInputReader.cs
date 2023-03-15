namespace SEDC.Class07.Inheritance.Sevices
{
    public class BaseInputReader
    {
        protected string GetStringFromScreen()
        {
            string input = Console.ReadLine();
            return input;
        }

        protected int GetIntFromScreen()
        {
            string input = Console.ReadLine();
            return Convert.ToInt32(input);
        }
    }
}
