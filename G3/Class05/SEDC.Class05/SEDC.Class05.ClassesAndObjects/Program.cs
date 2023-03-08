// See https://aka.ms/new-console-template for more information
using SEDC.Class05.ClassesAndObjects;

#region Classes
Console.WriteLine("Hello, World!");


Person person = new Person();
person.Name = "Trajan";
person.Age = 33;

person.Talk("Hellloooo!");

Person person1 = new Person()
{
    Name = "Dragan",
    Age = 22
};

person1.Talk("Good day!");

Person person2 = new Person("Bill Wurtz", 29);
person2.Talk("Heloooooo!");

var anonymousObj = new
{
    Name = "Trajan",
    Age = 22,
    DoB = true,
    IsValid = true,
    Date = DateTime.Now
};

//int[] nameInt = new int[2];
//string[] strings = new string[2];
//long[] longInt = new long[2];
//Person[] people = new Person[5];
//people[0] = new Person();



//
Student[] students = new Student[]
{
    new Student { Name = "Trajan", Academy = "Code", Group = "G3"},
    new Student { Name = "Dragan", Academy = "Code", Group = "G3"},
    new Student { Name = "Bob", Academy = "Code", Group = "G3" },
    new Student { Name = "Jill", Academy = "Code", Group = "G3"}
};

string userInput = "Trajan";

Student studentFound = null;
foreach(Student student in students)
{
    if(student.Name == userInput)
    {
        studentFound = student;
        break;
    }
}

if(studentFound == null)
{
    Console.WriteLine("Student not found");
}
else
{
    Console.WriteLine($"Stundet {studentFound.Name} was found");
}

#endregion

Console.WriteLine("===================================");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

User userNull = null;
User user = new User() { Name = "Trajan" };
Product productNull = null;
Product product = new Product() { Name = "Pc", Price = 100 };


void BuyStuffWithoutHandlingNull(
    User user, Product product, int cash)
{
    user.Talk();
    product.Buy(cash);
}

//BuyStuffWithoutHandlingNull(user, product, 120);

//BuyStuffWithoutHandlingNull(userNull, productNull, 120);

void BuyStuffWithHandlingNull(
    User user, Product product, int cash)
{
    if(user == null)
    {
        user = new User() { Name = "Unknown" };
    }
    user.Talk();
    if (product == null)
    {
        product = new Product() { Name = "a", Price = 100 };
    }
    product.Buy(cash);
}

//BuyStuffWithHandlingNull(userNull, productNull, 100);
//BuyStuffWithHandlingNull(user, product, 90);



User user1 = null;
if(userNull != null)
{
    user1 = userNull; 
}

User user2 = userNull ?? user;

User user3 = new User
{
    Name = null
};

string name = user3.Name ?? string.Empty;


void BuyStuffWithNullCoalescingOperator
    (User user, Product product, int cash)
{
    user.Talk();
    product.Buy(cash);
}

BuyStuffWithNullCoalescingOperator(
        userNull ?? user,
        productNull ?? product,
        1000
    );