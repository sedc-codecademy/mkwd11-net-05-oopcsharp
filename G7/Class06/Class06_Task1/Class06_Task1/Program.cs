namespace Class06_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given the following string
            //"The whole group of G7 loves C#.They find learning this language fun and easy!".
            //Print the text after the ".", using string methods.

            string text = "The whole group of G7 loves C#.They find learning this language fun and easy!";

            //First solution, using Split
            string[] lines = text.Split(".");
            Console.WriteLine(lines[1]);

            //Second solution, using Substring
            int startIndex = text.IndexOf(".") + 1;
            string secondPartOfText = text.Substring(startIndex);
            Console.WriteLine(secondPartOfText);
        }
    }
}