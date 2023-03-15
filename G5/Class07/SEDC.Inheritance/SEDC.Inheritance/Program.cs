using SEDC.Inheritance.Classes;

// Creating instances of all animals to see what constructors will be called and that
// All animals have access to methods from Animal
Animal animal1 = new Animal() { ID=1,Name="Dambo", Type="Elephant"};

animal1.PrintInfo();

Console.WriteLine("========= DOG ========");

Dog dog1 = new Dog() {ID=2, Name="Bak", Type="Dog", Race="Labrador" };

Dog dog2 = new Dog() { ID = 2, Name = "Bak", Race = "Mini" };

dog1.PrintInfo();
dog1.Bark();

dog2.PrintInfo();

Console.WriteLine("========= Cat ========");

//Cat cat1 = new Cat() { ID = 5, Name = "Garfild", Type = "Dog" };
Cat cat1 = new Cat() { ID = 5, Name = "Garfild",Lazyness = "Very" };// We don't tell the type here because the constructor will set it
cat1.PrintInfo();
cat1.Meow();