using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01
{
    public class LegalEntity : Client
    {
        public string Name { get; set; }
        private int _taxNumber { get; set; }
        public int EmployeeNo { get; set; }
        private int Profit { get; set; }
        public enum _activity
        {
            Manufacture,
            FoodProduction,
            Accounting,
            Clothing,
            Entertainment,
            Esports
        }
        public List<string> Owner { get; set; }

        public void generateTax()
        {
            int random = new Random().Next(1000, 9999);
            _taxNumber = (int)random;
        }
        

    }
}
