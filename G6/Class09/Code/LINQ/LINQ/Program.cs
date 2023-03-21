using LINQ;

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


//Find all dogs whose name has more than 3 characters
//this doesn't change the original list!!!
List<Dog> dogsWithNameLongerThan3 = dogs.Where(x => x.Name.Length > 3).ToList();

Console.WriteLine("====Original list:====");
foreach(Dog dog in dogs)
{
    Console.WriteLine(dog.Name);
}

Console.WriteLine("====Longer than 3====");
foreach (Dog dog in dogsWithNameLongerThan3)
{
    Console.WriteLine(dog.Name);
}


//All dogs whose name starts with S
List<Dog> dogsStartingWithS = dogs.Where(x => x.Name.StartsWith("S")).ToList();
Console.WriteLine("====With names starting with S====");
foreach (Dog dog in dogsStartingWithS)
{
    Console.WriteLine(dog.Name);
}

//find the first dog older than 2
Dog firstDogOlderThan2 = dogs.First(x => x.Age > 2);

//First will throw an Exception (gives error) when there is no object in the collection that fulfills the condition
//Dog dogWithNameOnA = dogs.First(x => x.Name.StartsWith("A"));

Dog dogWithNameOnA = dogs.FirstOrDefault(x => x.Name.StartsWith("A"));

if(dogWithNameOnA != null)
{
    Console.WriteLine($"There is a dog whose name starts with A: {dogWithNameOnA.Name}");
}

//First dog with age 1, whose name starts with B
Dog dogAged1 = dogs.FirstOrDefault(x => x.Age == 1 && x.Name.StartsWith("B"));

//second option
Dog dogAged1StartingWithB = dogs.Where(x => x.Age == 1 && x.Name.StartsWith("B")).FirstOrDefault();


//Take the names of all the dogs
List<string> dogsNames = dogs.Select(x => x.Name).ToList();
Console.WriteLine("===Dogs names:====");
foreach(string name in dogsNames)
{
    Console.WriteLine(name);
}

//Take the names of all the dogs aged 2
List<string> namesOfdogsAged2 = dogs.Where(x => x.Age == 2).Select(x => x.Name).ToList();

List<Dog> dogsAged2 = dogs.Where(x => x.Age == 2).ToList();
List<string> names = dogsAged2.Select(x => x.Name).ToList();

//Take the last dog aged 1
Dog lastDogAged1 = dogs.Last(x => x.Age == 1);
Dog lastDogAged1SecondOption = dogs.LastOrDefault(x => x.Age == 1);

//Dog lastDogAged5 = dogs.Last(x => x.Age == 5);
Dog lastDogAged5SecondOption = dogs.LastOrDefault(x => x.Age == 5);

//Take the name of the first dog aged 1
//FIRST OPTION
Dog firstDogAged1 = dogs.FirstOrDefault(x => x.Age == 1);  
if(firstDogAged1 != null)
{
    Console.WriteLine(firstDogAged1.Name);
}

//SECOND OPTION
string firstName = dogs.Where(x => x.Age == 1).Select(x => x.Name).FirstOrDefault();

List<Dog> dogsAged1 = dogs.Where(x => x.Age == 1).ToList();
List<string> namesOfdogsAged1 = dogsAged1.Select(x => x.Name).ToList();
string fName = namesOfdogsAged1.FirstOrDefault();

//returns empty list if the filter doesn't find objects that fulfill the condition
List<Dog> dogsAged5 = dogs.Where(x => x.Age == 5).ToList();
List<string> namesOfdogsAged5 = dogsAged5.Select(x => x.Name).ToList();
string fName5 = namesOfdogsAged5.FirstOrDefault();

Console.ReadLine();
