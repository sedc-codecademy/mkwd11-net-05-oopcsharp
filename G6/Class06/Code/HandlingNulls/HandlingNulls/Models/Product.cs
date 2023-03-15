

namespace HandlingNulls.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public void Buy(double money)
        {
            if(money >= Price)
            {
                Console.WriteLine($"You can buy {Name}");
            }
            else
            {
                Console.WriteLine($"You can't buy {Name}. You need {Price - money} money to buy it!");
            }
        }
    }
}
