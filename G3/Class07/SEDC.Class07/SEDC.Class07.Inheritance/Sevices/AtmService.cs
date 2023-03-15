using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class07.Inheritance.Sevices
{
    public class AtmService : BaseInputReader
    {
        public void Deposit()
        {
            int inputDeposit = GetIntFromScreen();
            // rest of the logic
        }
    }
}
