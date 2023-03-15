

namespace RetroExercise.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student()
        {

        }

        //constructor with params
        public Student(string firstName, string lastName, string academy, string group)
        {
            //if (string.IsNullOrEmpty(firstName))
            //{
            //    Console.WriteLine($"Invalid value for first name: {firstName}");
            //    FirstName = "Unknown";
            //}
            //else
            //{
            //    FirstName = firstName;  
            //}

            //if (string.IsNullOrEmpty(lastName))
            //{
            //    Console.WriteLine($"Invalid value for last name: {lastName}");
            //    LastName = "Unknown";
            //}
            //else
            //{
            //    LastName = lastName;    
            //}

            //if (string.IsNullOrEmpty(academy))
            //{
            //    Console.WriteLine($"Invalid value for academy: {academy}");
            //    Academy = "Unknown";
            //}
            //else
            //{
            //    Academy = academy;
            //}

            //if (string.IsNullOrEmpty(group))
            //{
            //    Console.WriteLine($"Invalid value for group: {group}");
            //    Group = "Unknown";
            //}
            //else
            //{
            //    Group = group;
            //}

            FirstName = ValidateInput(firstName, "firstName");
            LastName = ValidateInput(lastName, "lastName");
            Academy = ValidateInput(academy, "academy");
            Group = ValidateInput(group, "group");
        }

        private string ValidateInput(string input, string field)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"Invalid value for {field}: {input}");
                return "Unknown";
            }
            return input;
        }
    }
}
