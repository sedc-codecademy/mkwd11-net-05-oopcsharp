using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class07.Inheritance.Sevices
{
    public class UserService : BaseInputReader
    {
        public void CreateUser()
        {
            string firstName = GetStringFromScreen();
            string lastName = GetStringFromScreen();
            // rest of the logic
        }
    }
}
