using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class09.Exception.Classes
{
    public class Human
    {
        public Human()
        {

        }
        public Human(string fullName, List<Skill> skills)
        {
            FullName = fullName;
            SkillList = skills;
        }
        public string FullName { get; set; }
        public List<Skill> SkillList { get; set; } = new List<Skill>();
    }
}
