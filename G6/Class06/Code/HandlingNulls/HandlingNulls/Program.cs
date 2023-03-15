using HandlingNulls.Models;

Product product = new Product(); //empty object
product.Price = 100;

Product secondProduct = new Product()
{
    //here you can initialize all public properties
    Name = "Bread",
    Price = 50,
    Code = 111,
    Quantity = 20
};

Product car = null; //null as default value

//car.Buy(10000); ERROR

void TryToBuyProduct(Product product, double money)
{
    if(product == null)
    {
        Console.WriteLine("The product has null value!");
    }
    else
    {
        product.Buy(money);
    }
    
    //Without the if statement we can get an Exception if product == null
}

TryToBuyProduct(secondProduct, 150);
TryToBuyProduct(car, 1000);

//NULL COALESCING OPERATOR
//?? checks if the variable on the left side is null. If it is null, it takes the right side. If it is not null,
//it takes the left side.
TryToBuyProduct(car ?? new Product() { Price = 5000 }, 2000);
TryToBuyProduct(secondProduct ?? new Product() { Price = 5000 }, 2000);