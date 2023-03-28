using LINQ;

#region Initial Linq

Console.WriteLine("------------ Initial list-------------");
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5};
numbers.ForEach(num => Console.WriteLine(num));

//Select
Console.WriteLine("------------ Select-------------");
List<int> addOneToNumbers = numbers
                            //.Select((num, index) => num + 1)
                            .Select(num => num + 1)
                            .ToList();

foreach(int item in addOneToNumbers)
{
    Console.WriteLine(item);
}
// even lazier way to loop through all elements
addOneToNumbers.ForEach(num => Console.WriteLine(num));

//Where
Console.WriteLine("------------ Where-------------");
var greaterThanThree = numbers
                            .Where(num => num >= 3)
                            //.Select(num => num + 1)
                            .ToList();
greaterThanThree.ForEach(num => Console.WriteLine(num));

//First
Console.WriteLine("------------ First-------------");
int firstElement = numbers
                        .First();
Console.WriteLine(firstElement);


//Last
Console.WriteLine("------------ Last-------------");
int lastElement = numbers
                        .Last();
Console.WriteLine(lastElement);
#endregion

#region Chained Linq

Console.WriteLine("------------ Chained Linq-------------");

List<Dog> dogs = new List<Dog>
{
    new Dog{Name = "Charlie", Age = 2},
    new Dog{Name = "Butch", Age = 1},
    new Dog{Name = "Zoe", Age = 3},
    new Dog{Name = "Sia", Age = 1},
    new Dog{Name = "William", Age = 4},
    new Dog{Name = "Pongo", Age = 2},
    new Dog{Name = "Billy", Age = 1},
    new Dog{Name = "Buck", Age = 4},
};

// All dogs with name longer than 3 characters
List<Dog> nameLongerThan3 = dogs
                          .Where(x => x.Name.Length > 3)
                          .ToList();
nameLongerThan3.ForEach(x => Console.WriteLine(x.Name));

//First dog older than 3 years
var firstDogOlderThan3 = dogs
                            //.Where(x => x.Age > 3)
                            //.FirstOrDefault();
                            //.First();
                            .FirstOrDefault(x => x.Age > 3);
Console.WriteLine(firstDogOlderThan3.Name);
#endregion