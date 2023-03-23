using DemoCode.Classes;

Animal animal = new Animal();
//Console.WriteLine(animal.Id);
//Console.WriteLine(animal._privateProperty);

Dog jecky = new Dog();
Dog boby = new Dog("Boby", "Brown", "Labrador");
Console.WriteLine(boby.Name); //public
//Console.WriteLine(boby._privateProperty); ->private property
//Console.WriteLine(boby.Id); - > protected property

boby.PrintId();
//inherited method from Animal
boby.PrintBasicInfo();
boby.Eat("Meat");
boby.Eat();

Cat garfield = new Cat()
{
    Name = "Garfield",
    Color = "Orange",
    IsLazy = true
};

garfield.PrintBasicInfo();
garfield.Eat("Fish");
