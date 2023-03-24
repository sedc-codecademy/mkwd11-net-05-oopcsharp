using System.Globalization;

namespace Class08_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                { "Risto", "070123451"},
                { "Tijana", "070123452"},
                { "Martin", "070123453"},
                { "Chirstos", "070123454"},
                { "Frosina", "070123455"},
            };

            Console.Write("Please write a name for a search: ");

            string input = Console.ReadLine(); //RiSto

            //Usage of ToTitleCase as a function
            //TextInfo textInfo = new CultureInfo("en-US").TextInfo;
            //string formattedInput = textInfo.ToTitleCase(input);

            //Manual way of formatting the string to title case
            //string formattedInput = input.ToLower(); //risto
            //string firstLetter = formattedInput.Substring(0, 1).ToUpper(); // r => R
            //formattedInput = firstLetter + formattedInput.Substring(1); // R + isto

            //bool exists = phoneBook.ContainsKey(formattedInput);

            //if(exists)
            //{
            //    Console.WriteLine($"{formattedInput} - {phoneBook[formattedInput]}");
            //} else
            //{
            //    Console.WriteLine("Name does not exist");
            //}

            bool nameFound = false;
            foreach(KeyValuePair<string, string> phone in phoneBook)
            {
                if(phone.Key.ToLower() == input.ToLower())
                {
                    Console.WriteLine($"{phone.Key} - {phone.Value}");
                    nameFound = true;
                    break;
                }
            }

            if(!nameFound)
            {
                Console.WriteLine("Name does not exist");
            }
        }
    }
}