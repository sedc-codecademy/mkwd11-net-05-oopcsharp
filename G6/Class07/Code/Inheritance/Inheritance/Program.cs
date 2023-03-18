using Inheritance.Models;

Animal animal = new Animal();
animal.Name = "Test Animal";
//animal.Id = 1; private!!!
animal.Type = "Test";
//animal.Age protected!!!
animal.PrintIdentifier(); //call implementation from Animal
//animal.PrintAge(); //doesn't exist in Animal

Cat cat = new Cat();
cat.Name = "Sharko";
cat.Type = "Cat";
cat.PrintIdentifier(); //call implementation from Cat class
//cat.Age protected, accessible only in Animal and the classes in the inheritance tree below Animal
cat.PrintAge();

Dog dog = new Dog();
dog.Color = "black";
dog.PrintIdentifier();
//dog.PrintAge(); //PrintAge is only specific for Cat

//dog.Identifier = 8785; ERROR

Dog newDog = new Dog("Lesi", "Brown");

newDog.PrintInfo(); //inherited from base class
newDog.PrintIdentifier();

Console.ReadLine();
