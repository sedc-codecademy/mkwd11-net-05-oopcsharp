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


List<Person> morePeople = new List<Person>()
{
    new Person("Bob", 25),
    new Person("Zack", 18),
    new Person("Gary", 18)
};


Console.WriteLine("Before Adding");
people.ForEach(person => person.GetInfo());

Console.WriteLine();

people.AddRange(morePeople);

Console.WriteLine();

Console.WriteLine("After Adding");
people.ForEach(person => person.GetInfo());

Console.WriteLine();

// First & FirstOrDefault

Person first18YearOld = people.First(person => person.Age == 18);
first18YearOld.GetInfo();

Console.WriteLine();

// Throws Error if no person is found
//Person first99YearOld = people.First(person => person.Age == 99);
//first99YearOld.GetInfo();

Person firstOrDefault18YearOld = people.FirstOrDefault(person => person.Age == 18);
firstOrDefault18YearOld.GetInfo();

Console.WriteLine();

Person firstOrDefault99YearOld = people.FirstOrDefault(person => person.Age == 99);

if (firstOrDefault99YearOld != null)
{
    firstOrDefault99YearOld.GetInfo();
}
else
{
    Console.WriteLine("No such person found!");
}

Console.WriteLine();

// Last & LastOrDefault

Person last18YearOld = people.Last(person => person.Age == 18);
last18YearOld.GetInfo();

Console.WriteLine();

//Person last99YearOld = people.Last(person => person.Age == 99);
//last99YearOld.GetInfo();

Person lastOrDefault18YearOld = people.LastOrDefault(person => person.Age == 18);
lastOrDefault18YearOld?.GetInfo();

Console.WriteLine();

Person lastOrDefault99YearOld = people.LastOrDefault(person => person.Age == 99);

if (lastOrDefault99YearOld != null)
{
    lastOrDefault99YearOld.GetInfo();
} else
{
    Console.WriteLine("No such person found!");
}

Console.WriteLine("Alternative Way to use First, FirstOrDefault, Last & LastOrDefault");

var peopleWith18Years = people.Where(x => x.Age == 18).ToList();
peopleWith18Years.ForEach(person => person.GetInfo());

Console.WriteLine("==============");

Person first18YearOldAlternativeWay = peopleWith18Years.FirstOrDefault();
first18YearOldAlternativeWay.GetInfo();

Console.WriteLine("================");

Person firstPerson = people.FirstOrDefault();
firstPerson.GetInfo();

Console.WriteLine("================");

Person firstPersonWith18Years = people.Where(x => x.Age == 18).LastOrDefault();