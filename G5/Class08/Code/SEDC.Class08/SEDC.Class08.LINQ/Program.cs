using SEDC.Class08.Domain;

List<Person> people = new List<Person>()
{
    new Person("John", 15),
    new Person("Anna", 30),
    new Person("Mike", 29),
    new Person("Mark", 25),
    new Person("Michael", 35),
    new Person("William", 45),
};

// Where - Filters
// =>  Lambda
List<Person> nameLongerThan5List = people.Where(person => person.Name.Length > 5).ToList();
IEnumerable<Person> nameLongerThan5Enumerable = people.Where(person => person.Name.Length > 5);


// We cannot access ForEach on IEnumerable type, thats why we convert it to collection that can access it (List)
Console.WriteLine("[List] Names longer than 5 characters: ");
// List -> Contains definition for ForEach
nameLongerThan5List.ForEach(person => person.GetInfo());

Console.WriteLine();

Console.WriteLine("[IEnumerable] Names longer than 5 characters: ");
// IEnumerable -> Does not contain definition for ForEach
foreach (var item in nameLongerThan5Enumerable)
{
    item.GetInfo();
}

Console.WriteLine();

List<Person> olderThan20 = people.Where(person => person.Age > 20).ToList();
Console.WriteLine("People older than 20: ");
olderThan20.ForEach(person => person.GetInfo());

Console.WriteLine();

// Select

List<string> peopleNames = people.Select(person => person.Name).ToList();
Console.WriteLine("Names: ");
peopleNames.ForEach(name => Console.WriteLine(name));

Console.WriteLine();

List<int> peopleAges = people.Select(person => person.Age).ToList();
Console.WriteLine("Ages: ");
peopleAges.ForEach(age => Console.WriteLine(age));

Console.WriteLine();

// Chaining

List<string> namesOfPeopleOlderThan30 = people.Where(person => person.Age > 30).Select(person => person.Name).ToList();

Console.WriteLine("Names of people older than 30:");
namesOfPeopleOlderThan30.ForEach(name => Console.WriteLine(name));