using SEDC.Class08.Domain;
using System.Collections;


#region Methods

void GoThroughStringArrayCollection(string[] collection, string name)
{
    // Console.WriteLine($"Collection {collection.GetType().ToString().Split('.')[1]} items:");
    Console.WriteLine($"Collection {name} items:");
    Console.WriteLine();
    foreach (string collectionItem in collection)
        Console.WriteLine(collectionItem);

    Console.WriteLine("========================");
}

void GoThroughIntArrayCollection(int[] collection, string name)
{
    Console.WriteLine($"Collection {name} items:");
    Console.WriteLine();
    foreach (int collectionItem in collection)
        Console.WriteLine(collectionItem);

    Console.WriteLine("========================");
}

// IEnumerable ( abstraction ) - something that can be interated 
void GoThroughCollection(IEnumerable collection, string name)
{
    Console.WriteLine($"Collection {name} items:");
    Console.WriteLine();
    foreach (var collectionItem in collection)
        Console.WriteLine(collectionItem);

    Console.WriteLine("========================");
}

#endregion


#region Non-Generic Collections



// Arrays

string[] emptyStringArray = new string[3];
string[] stringArray = new string[] { "Hello", "World", "!" };
int[] intArray = new int[] { 1, 2, 3 };
double[] doubleArray = new double[] { 1.1, 10.10, 15.2 };

GoThroughStringArrayCollection(stringArray, "string[]");
GoThroughIntArrayCollection(intArray, "int[]");
GoThroughCollection(doubleArray, "double[]");

var myObj = new
{
    Name = "John",
    Age = 20
};


// Non - generic collections, are collections that can store objects of any type.
// They are not type-safe
// Is more flexibility better?
// On the short run more flexibility seems better, but on the long run it will be difficult to manipulate with the collection.

// ArrayList
ArrayList arrayList = new ArrayList() { 1, 2, 3, "John", '!', 2.15 };
arrayList.Add(intArray);
arrayList.Add(doubleArray);
arrayList.Add(myObj);

GoThroughCollection(arrayList, "ArrayList");

arrayList.Remove('!');

GoThroughCollection(arrayList, "ArrayList");

Console.WriteLine($"First index in ArrayList -> {arrayList[0]}");

Console.WriteLine();
#endregion


#region Generic Collection

// Generic collections are strongly typed collections that allow you to store a specific type of object.
// The advantage of generic collections is that they provide type safety

// List

List<int> listOfIntegers = new List<int>();
listOfIntegers.Add(2);
listOfIntegers.Add(1);
listOfIntegers.Add(10);

GoThroughCollection(listOfIntegers, "List<int>");

listOfIntegers.Remove(1);

GoThroughCollection(listOfIntegers, "List<int>");

listOfIntegers.Remove(100);

GoThroughCollection(listOfIntegers, "List<int>");

Console.WriteLine($"This list contains {listOfIntegers.Count} elements");

Console.WriteLine();

Console.WriteLine($"Element with index 1 inside listOfIntegers is {listOfIntegers[1]}.");

Console.WriteLine();


// NON-INDEXABLE COLLECTIONS -> We cannot access elemets by index inside these collections

// Dictionary (Key/Value Pairs)

Dictionary<string, string> musicCollection = new Dictionary<string, string>();
musicCollection.Add("Song1", "Winds of Change");
musicCollection.Add("Song2", "Enter Sandman");

GoThroughCollection(musicCollection, "Dictionary<string, string>");

musicCollection.Remove("Song1");

GoThroughCollection(musicCollection, "Dictionary<string, string>");

Dictionary<string, int> phoneBook = new Dictionary<string, int>()
{
    { "John", 070123123 },
    { "Mike", 077123123 },
    { "Anna", 075123321 }
};


GoThroughCollection(phoneBook, "phonebook");

// Get only keys
GoThroughCollection(phoneBook.Keys, "phonebook keys");

// Get only values
GoThroughCollection(phoneBook.Values, "phonebook values");

// Get value by key
Console.WriteLine($"Mikes number: {phoneBook["Mike"]}");

Console.WriteLine();

// ORDERED COLLECTION -> There is a specific order how we add and how we remove elements from these collections

// Queue (First in first out - FIFO)

// Cannot directly add elements to the queue
// Queue<int> someQueue = new Queue<int>() { 1, 2, 3, 4, 5 }

Queue<int> someQueue = new Queue<int>();
someQueue.Enqueue(1);
someQueue.Enqueue(10);
someQueue.Enqueue(15);

GoThroughCollection(someQueue, "Queue<int>");

someQueue.Dequeue();

GoThroughCollection(someQueue, "Queue<int>");

// Gets the next dequeued element
Console.WriteLine($"Queue Peek -> {someQueue.Peek()}");
Console.WriteLine();


// Stack (Last in first out - LIFO)

// Cannot directly add elements to the stack
// Stack<string> someStack = new Stack<string>() { "word1", "word2" };

Stack<string> chair = new Stack<string>();
chair.Push("Green T-Shirt");
chair.Push("Socks");
chair.Push("Jeans");
chair.Push("Black T-Shirt");

GoThroughCollection(chair, "Stack<string>");

chair.Pop();

GoThroughCollection(chair, "Stack<string>");

chair.Pop();

GoThroughCollection(chair, "Stack<string>");

Console.WriteLine($"On top of the pile of clothes, there is {chair.Peek()}");

chair.Pop();
bool canBeRemoved = chair.TryPop(out string removedElement);

if (canBeRemoved)
{
    Console.WriteLine($"You just removed {removedElement} from the pile of clothes");
}
else
{
    Console.WriteLine("The chair is empty");
}

Console.WriteLine($"Stack leftover elements: {chair.Count}");

Console.WriteLine();

#endregion


#region Common Problem
// We need to add default value to collection property, otherwise it will be null and will throw exception when we use methods on top of it (ex. Add / Remove)

// null.Add() / null.Remove() will throw exception

Dog dog = new Dog("Max");
dog.FavouriteFoods.Add("Beef");

Console.WriteLine($"{dog.Name} favourite foods are: ");
foreach (string food in dog.FavouriteFoods)
    Console.WriteLine(food);

#endregion

#region Exercise 1
Console.WriteLine();
Console.WriteLine("======= Exercise 1 =======");

Dictionary<string, long> phoneBookDictionary = new Dictionary<string, long>()
{
    {"Bob", 70993241 },
    {"Will", 71234232 },
    {"Meg", 72778900 },
    {"Jill", 71562110 },
    {"Buck", 71119804 }
};

Console.WriteLine("Enter name:");
PrintPhone(phoneBookDictionary, Console.ReadLine());


void PrintPhone(Dictionary<string, long> phoneBook, string name)
{
    if (!phoneBook.ContainsKey(name))
    {
        Console.WriteLine($"There is no {name} in this phoneBook. Sorry!");
        return;
    }
    Console.WriteLine($"{name}'s phone is: 0{phoneBook[name]}");
}

#endregion