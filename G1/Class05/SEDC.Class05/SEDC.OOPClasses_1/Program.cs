using SEDC.OOPClasses_1.Models;


// Create an object by using the default constructor
Person person = new Person();
person.FirstName = "Martin";
person.LastName = "Panovski";


DateTime birthDate = DateTime.Parse("08/27/1993");

person.GetYearsOldInfo(birthDate);

person.SetPhoneNumber("070/222-333");
Console.WriteLine(person.GetPhoneNumber());
Console.WriteLine(person.FirstName);


// Create an object using constructor with parameters
Book book = new Book("Harry Potter 1", "J.K. Rowling", "123456789", 300, "Adventure");

Console.WriteLine(book.GetBookInfo());

Book book1 = new Book();
book1.Title = "Harry Potter 2";

Book book2 = new Book("Harry Potter 3");



// Create an object by using the objcet initializer

Person person1 = new Person()
{
    FirstName = "Antonio",
    LastName = "Novoselski"
};


Person person2 = new Person
{
    FirstName = "Antonio",
    LastName = "Novoselski"
};


Person person3 = new()
{
    FirstName = "Antonio",
    LastName = "Novoselski"
};