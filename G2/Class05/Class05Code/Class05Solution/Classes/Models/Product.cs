using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        //public Product()
        //{

        //}

        public void Buy(double amount)
        {
            if(amount >= Price)
            {
                Console.WriteLine($"You can buy the product: {Name}");
            }
            else
            {
                Console.WriteLine("You can not buy the product");
            }
        }
    }
}
