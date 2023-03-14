

namespace Exercise
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human()
        {

        }

        public Human(string firstName, string lastName, int age)
        {
            //check if firstName is null or "". Returns true or false
            if(string.IsNullOrEmpty(firstName)) 
            {
                Console.WriteLine("Invalid firstName value");
                FirstName = "Default value";
            }
            else
            {
                FirstName = firstName;
            }

            //check if lastName is null or "". Returns true or false
            if (string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("Invalid lastName value");
                LastName = "Default value";
            }
            else
            {
                LastName = lastName;
            }

            //check if age is zero or negative number
            Age = age;
        }

        public string GetPersonStats()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
}
