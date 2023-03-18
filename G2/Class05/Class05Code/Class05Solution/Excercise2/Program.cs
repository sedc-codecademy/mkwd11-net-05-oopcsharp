using Excercise2;

Dog puppy = new Dog();
Console.WriteLine("Give the puppy a name:");
puppy.Name = Console.ReadLine();
Console.WriteLine("Choose its color: ");
puppy.Color = Console.ReadLine();
Console.WriteLine("Which breed is it?");
puppy.Breed = Console.ReadLine();
puppy.Command();
