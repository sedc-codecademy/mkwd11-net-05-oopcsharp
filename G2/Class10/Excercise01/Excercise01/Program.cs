// See https://aka.ms/new-console-template for more information


using Excercise01;

List<Person> listOfPersons = new List<Person>();

Person Kiril = new Person()
{
    FirstName = "Kiril",
    LastName = "Jordanov",
    Age = 14,
    State = "Skopje",
    Email = "kiril.Jordanovsd@gmail.com",
    Mobile = "078447419",
    
    
};
Kiril.EmailCheck(Kiril.Email);
Kiril.PhoneCheck(Kiril.Mobile);
Kiril.OccupationCheck(Kiril.Age);