using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class User
    {
        public User(string username, string firstname, string lastname, int age)
        {
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }
    }
}
