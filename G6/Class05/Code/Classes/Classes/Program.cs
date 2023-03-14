using Classes;

//call default constructor
Person firstPerson = new Person();
firstPerson.FirstName = "Petko";

//_ssn is private and can be accessed only in the class
//firstPerson._ssn -> ERROR

//call constructor with parameters
Person secondPerson = new Person("Marko", "Markovski", 22, 123456);
Console.WriteLine($"{secondPerson.FirstName} {secondPerson.LastName}");
secondPerson.PrintDetails();

secondPerson.SetSsn(234567);

secondPerson.PrintDetails();

secondPerson.Says("Goodbye");