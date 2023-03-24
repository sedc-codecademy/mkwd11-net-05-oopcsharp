using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class09.Exception.Classes
{
    public class Skill
    {
        public Skill(string name, int point)
        {
            Name = name;
            Point = point;
        }

        public string Name { get; set; }
        public int Point { get; set; }
    }
}
