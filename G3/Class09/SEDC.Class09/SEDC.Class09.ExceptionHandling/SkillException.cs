using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class09.ExceptionHandling
{
    public class SkillException : Exception
    {
        public SkillException(string message)
            : base(message)
        {
            
        }
    }
}
