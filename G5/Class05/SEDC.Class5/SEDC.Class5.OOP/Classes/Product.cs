namespace SEDC.Class5.OOP.Classes
{
    public class Product
    {
        // Even if we lose the default parameterless constructor provided by c#, we can always recreate it manually (recreate it manually only if you need it, this is just an example)
        // This constructor is going to construct empty products (product without Name and Price)
        public Product()
        {
            
        }

        // We created a constructor inside Product, because of that we lost the default parameterless constructor that is provided to us by c#
        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
