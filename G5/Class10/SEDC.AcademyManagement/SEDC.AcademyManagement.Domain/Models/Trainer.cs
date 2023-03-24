using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class Trainer : User
    {
        public Trainer(string username, string firstname, string lastname, int age) : base(username, firstname, lastname, age)
        {
            Role = Role.Trainer;
        }
    }
}
