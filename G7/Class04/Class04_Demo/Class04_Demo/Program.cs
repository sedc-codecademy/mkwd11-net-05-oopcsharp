namespace Class04_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Risto";
            string secondName = "Panchevski";

            //string fullName = firstName + secondName;

            //string fullName = firstName + " " + secondName;
            //string fullName = string.Format("Hello: {0} {1}", firstName, secondName);
            string fullName = $"Hello: {firstName} {secondName}";
            Console.WriteLine(fullName);
        }
    }
}