using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class09.ExceptionHandling
{
    public class HumanException : Exception
    {
        public int ExceptionNumber { get; set; }

        public HumanException(string message, int exNumber)
            : base(message)
        {
            ExceptionNumber = exNumber;
        }
    }
}
