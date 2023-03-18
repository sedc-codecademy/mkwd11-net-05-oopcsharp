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


// ArrayList
// They are not type-safe
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


// NON-INDEXABLE COLLECTIONS

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
GoThroughCollection(phoneBook.Keys, "phonebook keys");
GoThroughCollection(phoneBook.Values, "phonebook values");

Console.WriteLine($"Mikes number: {phoneBook["Mike"]}");

Console.WriteLine();

// ORDERED COLLECTION

// Queue (First in first out - FIFO)

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

Dog dog = new Dog("Max");
dog.FavouriteFoods.Add("Beef");

Console.WriteLine($"{dog.Name} favourite foods are: ");
foreach (string food in dog.FavouriteFoods)
    Console.WriteLine(food);

#endregion