using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class05.ClassesAndObjects
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }


        public void Buy(double money)
        {
            if(money >= Price)
            {
                Console.WriteLine($"You just bought a {Name}");
            }
            else 
            {
                Console.WriteLine($"You need {Price - money} more to buy this item!");
            }
        }
    }
}
