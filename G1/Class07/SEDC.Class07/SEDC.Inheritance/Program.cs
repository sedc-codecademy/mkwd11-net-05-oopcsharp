using SEDC.Inheritance.Academy;
using SEDC.Inheritance.Animals;
using SEDC.Methods;

#region Animals
// Initialize new object using object initializer {}
// This use the deffault constructor in order to create a new object

Animal animal = new Animal() { Name = "Animal", Color = "Color", YearsOld = 0 };

// Initialize new object using constructor with parameters
// This use the constructor with all the 3 parameters

Animal animal1 = new Animal("Animal1", "Animal1 color", 0);


Console.WriteLine(animal.Name);
animal.GetInfo();


Dog bucky = new Dog() { Name = "Bucky", Color = "Brown", YearsOld = 5, Breed = "Labrador" };
//bucky.GetInfo();
//bucky.Bark();
//bucky.GetDogInfo();

bucky.GetInfo();

// This is possible because Dog is a child of Animal 
// or the Dog class inherits from the Animal class
Animal riki = new Dog();


Cat mobi = new Cat() { Name = "Mobi", Color = "Grey", YearsOld = 3, FavouriteFood = "Fish" };
//mobi.Play();
//mobi.GetCatInfo();
mobi.GetInfo();
#endregion


#region Academy

Trainer trainer = new Trainer()
{
    FirstName = "Martin",
    LastName = "Panovski",
    Age = 29,
    YearsOfExperience = 5,
    Role = Roles.Trainer
};

Student student = new Student()
{
    FirstName = "Petko",
    LastName = "Petkovski",
    Age = 23,
    Subjects = new string[] { "C#", "JavaScript", "AJS" },
    Role = Roles.Student
};


Console.WriteLine("What role do you need to access? Trainer or Student");
string userInput = Console.ReadLine();

if(userInput.ToLower() == Roles.Trainer.ToString().ToLower())
{
    trainer.GetInfo();
}
else if(userInput.ToLower() == Roles.Student.ToString().ToLower())
{
    student.GetInfo();
}
else
{
    Console.WriteLine("Wrong input!");
}


#endregion


CustomMath math = new CustomMath();
math.Sum(10, 20);
math.Sub(20, 5);

