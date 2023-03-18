using Models;

namespace Class07_DemoEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza()
            {
                Name = "Capri",
                Size = SizeEnum.Small,
                Price = 200
            };

            Pizza pizza2 = new Pizza()
            {
                Name = "Peperoni",
                Size = SizeEnum.Large,
                Price = 300
            };

            Order order = new Order()
            {
                Pizza = pizza1,
                Status = StatusEnum.Ordered
            };

            //some logic for processing the pizza
            order.Status = StatusEnum.InProgress;

            //after some time, pizza is ready
            order.Status = StatusEnum.PickedUpForDelivery;

            //after some time, pizza is delivered
            order.Status = StatusEnum.Delivered;


            if(order.Status == StatusEnum.Ordered)
            {
                Console.WriteLine("Thank you for your order");
            }

            if (order.Status == StatusEnum.Delivered)
            {
                Console.WriteLine("Please send us a feedback");
            }
        }
    }
}