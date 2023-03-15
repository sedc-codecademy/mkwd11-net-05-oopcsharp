using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Exercise.Car.Models
{
    public class Driver
    {
        public Driver(string name, int level)
        {
            Name = name;
            Level = level;
        }
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
