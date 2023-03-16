
using SEDC.Exercise_1.Models;

//Task 1
//Create a class Dog
//Add properties: Name, Race, Color
//The dog needs to have an Eat() method that returns message: The dog is now eating.
//A Play() method returning a message : The dog is now playing. and a
//ChaseTail() method that returns a message: Dog is now chasing its tail.
//The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.



Console.WriteLine("Please insert Name, Race and Color for your dog:");


Console.Write("Name:");
string name = Console.ReadLine();

Console.Write("Race:");
string race = Console.ReadLine();

Console.Write("Color:");
string color = Console.ReadLine();

Dog dog = new Dog() {Name = name, Race  = race, Color = color};
Dog dog2 = new Dog() {Name = name, Race  = race, Color = color};
Dog dog3 = new Dog() {Name = name, Race  = race, Color = color};

Console.WriteLine("So far so good! What do you want your dog to do now?\n1.Eat \n2. Play \n3.Chase its tail");


int userChoice = int.Parse(Console.ReadLine());

switch (userChoice)
{
	case 1:
        Console.WriteLine(dog.Eat());
        break;
    case 2:
        Console.WriteLine(dog.Play());
        break;
    case 3:
        Console.WriteLine(dog.ChaseTail());
        break;
    default:
		break;
}