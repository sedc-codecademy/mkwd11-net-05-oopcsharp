using SEDC.Class5.OOP.Classes;

#region Classes and objects

Person personConstructedFromTheParameterlessConstructor = new Person();
personConstructedFromTheParameterlessConstructor.Name = "John";
personConstructedFromTheParameterlessConstructor.Age = 25;

Person personConstructedFromTheParameterlessConstructor2 = new Person()
{
    Name = "Jim",
    Age = 25
};

Person person = new Person("John", 25);
person.Talk("Hello There");

ConsoleHelper.Separator();

Person person1 = new Person("Jim", 30);
person1.Talk("Hello G5!");

ConsoleHelper.Separator();


// How does parameterless constructor work?
// Step 1 =>  new Person() creates us an empty Person object
Person person3 = new Person();
person3.Talk("I am still unnamed");
/*
- How the object looks when created initially - The object provided below is just an example (if you uncomment it, it will not work)
Person person3Before = new Person()
{
    Name = "Unnamed",       -> The parameterless constructor does not populate the Name property, Name is going to take the default value
    Age = 1,                -> The parameterless constructor does not populate the Age property, Age is going to take the default value
    Balance = 0,            -> The parameterless constructor does not populate the Balance property, Balance is going to take the default value
    PersonalNumber = 123456 -> The parameterless constructor sets the PersonalNumber via the private method inside the Person class
}
*/


// Manually modifying properties
person3.Name = "Angel";
person3.Age = 21;
// We cannot access private properties and methods from outside the class
// person3.PersonalNumber = 123456;
// person3.GeneratePersonalNumber();

/*
- How will the object look after the manual modification - The object provided below is just an example (if you uncomment it, it will not work)
Person person3After = new Person()
{
    Name = "Angel",
    Age = 21,
    Balance = 0,
    PersonalNumber = 123456
}
*/

person3.Talk("Bye!");

ConsoleHelper.Separator();

// Created via the last constructor
Person person4 = new Person("Jane", 34, 1500);

// Creating products
Product sneakers = new Product("Nike Sneakers", 200);
Product phone = new Product("iPhone", 500);
Product tShirt = new Product("Addidas T-Shirt", 100);

// Manually setting the balance of a object
person1.CheckBalance();
person1.Balance = 600;
person1.CheckBalance();

ConsoleHelper.Separator();

person1.BuyProduct(phone);

ConsoleHelper.Separator();

person1.BuyProduct(tShirt);

ConsoleHelper.Separator();

person1.BuyProduct(sneakers);

ConsoleHelper.Separator();
#endregion

#region Array of objects

//Array of objects
Person[] personArray = new Person[] { person, person1, person3, person4 };
Product[] productArray = new Product[] { sneakers, phone, tShirt };

//foreach (Person p in personArray)
//{
//    Console.WriteLine(p.Name);
//}

//foreach (Product p in productArray)
//{
//    Console.WriteLine(p.Name);
//}


#endregion

#region Anonymous object

// Anonymous object
// We cant add methods in these objects, just properties
var annonymousObj = new
{
    FirstName = "Jill",
    LastName = "Smith"
};

// Cannot change values of properties once anonymous object is created
// Throws error
//annonymousObj.FirstName = "Mike"

Console.WriteLine($"Annonymous object: {annonymousObj.FirstName} {annonymousObj.LastName}");

#endregion

#region Static Classes

// We cannot create objects out of static class, we use it directly
// We invoke static methods directly on the class instead of creating an object out of it first

//Console console = new Console();
//console.WriteLine();

//Math math = new Math();
//math.Round();

// Proper use of static methods
Math.Round(100.1);
ConsoleHelper.Separator();

#endregion

#region Null Handling

// Jim & 25 => Proveruva vo baza => Ako ne najde takov person ke vrati null
Person nobody = null;
Product nothing = null;

void BuyProductWithoutNullHandling(Person person, Product product)
{
    person.Talk($"{person.Name} is buying {product.Name}");
    person.BuyProduct(product);
}

// Throws error
//BuyProductWithoutNullHandling(nobody, nothing);


void BuyProductWithNullHandling(Person person, Product product)
{
    if (person == null) person = new Person("Unknown", 20);
    if (product == null) product = new Product("Unknown", 0);

    person.Talk($"{person.Name} is buying {product.Name}");
    person.BuyProduct(product);
}

//BuyProductWithNullHandling(nobody, nothing);

// Coalescating Operator ( ?? ) - Null Check

void BuyProductWithNullCoalescatingOperator(Person person, Product product)
{
    person.Talk($"{person.Name} is buying {product.Name}");
    person.BuyProduct(product);
}

// Uncomment this line and you will see that nobody is not going to take the Unknown person
//nobody = new Person("Angel", 21, 100);
BuyProductWithNullCoalescatingOperator(nobody ?? new Person("Unknown", 20), nothing ?? new Product("Unknown", 0));


// Null-Coalescating Assignment Operator ( ??= )
// Only assigns if the left side is null

Person somebody = new Person("Jim", 20, 150);
somebody ??= new Person("Unknown", 20);

Person nobodyAgain = null;
nobodyAgain ??= new Person("Unknown", 21);

Console.WriteLine(somebody.Name);
Console.WriteLine(nobodyAgain.Name);

#endregion