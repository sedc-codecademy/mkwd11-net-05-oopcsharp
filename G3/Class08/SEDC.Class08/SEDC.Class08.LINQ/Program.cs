// See https://aka.ms/new-console-template for more information
using SEDC.Class08.LINQ;

void GoThroughDogCollection(List<Dog> dogs) {
    foreach(Dog dog in dogs)
    {
        Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}");
    }
}

List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name = "Sparky", Age = 2},
                new Dog(){Name = "Butch", Age = 1},
                new Dog(){Name = "Zoe", Age = 3},
                new Dog(){Name = "Sia", Age = 1},
                new Dog(){Name = "William", Age = 4},
                new Dog(){Name = "Billy", Age = 1},
                new Dog(){Name = "Buck", Age = 2}
            };

// All dogs with name longer than 3 letters
List<Dog> dogsWithNameLongerThen3Characters = new List<Dog>();
foreach(Dog dog in dogs)
{
    if(dog.Name.Length > 3)
    {
        dogsWithNameLongerThen3Characters.Add(dog);
    }
}

//GoThroughDogCollection(dogsWithNameLongerThen3Characters);

List<Dog> nameLongerThan3 = dogs.Where(dog => dog.Name.Length > 3).ToList();
//GoThroughDogCollection(nameLongerThan3);

// All dogs that have a name starting with S
List<Dog> nameStartsWithS = dogs.Where(dog => dog.Name.StartsWith('S')).ToList();
GoThroughDogCollection(nameStartsWithS);

// First dog that is of age 1 and have a name that starts with B
Dog firstDogWithAge1AndNameStartsWithB =
    dogs
        .Where(dog => dog.Age == 1)
        .Where(dog => dog.Name.StartsWith('B'))
        .FirstOrDefault();

Dog firstDogWithAge1AndNameStartsWithB1 =
    dogs.FirstOrDefault(dog => dog.Age == 1 && dog.Name.StartsWith('B'));

// All names of dogs
List<string> namesOfDogs =  new List<string>();
foreach(Dog dog in dogs)
{
    namesOfDogs.Add(dog.Name);
}

List<string> dogNames = dogs.Select(dog => dog.Name).ToList();

foreach(string name in namesOfDogs)
{
    Console.WriteLine(name);
}

// All ages of dogs

List<int> dogAges = dogs.Select(x => x.Age).ToList();



// All names of dogs that are the age of 2

List<string> dogsOfAge =
    dogs
        .Where(x => x.Age == 2)
        .Select(x => x.Name)
        .ToList();