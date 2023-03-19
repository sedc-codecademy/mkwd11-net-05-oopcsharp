// See https://aka.ms/new-console-template for more information
using SEDC.Class08.Collections;
using System.Collections;

Console.WriteLine("Hello, World!");

void GoThroughCollection(IEnumerable collection, string name)
{
    Console.WriteLine($"Collection {name} items: ");
    foreach(var item in collection)
    {
        Console.WriteLine($"{item}");
    }
    Console.WriteLine();
}

#region List
int[] integerArray = new int[1];
integerArray[0] = 1;
Array.Resize(ref integerArray, integerArray.Length + 1);
integerArray[1] = 10;

List<int> listOfIntegers = new List<int>();
listOfIntegers.Add(1);
listOfIntegers.Add(10);
listOfIntegers.Add(111);
listOfIntegers.AddRange(integerArray);

listOfIntegers.Remove(111);
Console.WriteLine(listOfIntegers[0]); //read value
listOfIntegers[1] = 190; //set value
GoThroughCollection(listOfIntegers, "List of integers");

List<string> listOfStrings = new List<string>()
{
    "Trajan",
    "Dragan",
    "Bob",
    "Jill"
};

int numberOfElements =  listOfStrings.Count;

GoThroughCollection(listOfStrings, "List of strings");


//List<Student> students = new List<Student>();

#endregion


#region Dictionary

Dictionary<string, string> dictionaryOne 
    = new Dictionary<string, string>();
dictionaryOne.Add("key", "value");
dictionaryOne.Add("Second key", "second value");
// dictionaryOne.Add("key", "asddda"); // this will raise an exception

dictionaryOne.Remove("key");

GoThroughCollection(dictionaryOne, "Dictionary one");

string valueByKey = dictionaryOne["Second key"]; // read value by key
dictionaryOne["Second key"] = "Changed second key"; // set value by key

int countOfDIctionary = dictionaryOne.Count;

Dictionary<int, string> products = new Dictionary<int, string>()
{
    { 12345, "Potato" },
    { 123456, "Salt"  },
    { 12346, "Butter" }
};

bool isContainingKey = products.ContainsKey(12345); // return true
bool hasValue = products.TryGetValue(12345, out string value); // something like TryParse

GoThroughCollection(products, "Products");

Dictionary<int, Student> dictionaryIdStudent = new Dictionary<int, Student>();

#endregion


#region Stack and Queue

Queue<int> someQueue = new Queue<int>();
someQueue.Enqueue(25); // add
someQueue.Enqueue(3);
someQueue.Enqueue(2);
someQueue.Enqueue(111);

// 25, 3, 2, 111 -> 25 -> 3 -> 2 -> 111

int a = someQueue.Dequeue(); // remove
Console.WriteLine(someQueue.Peek());

GoThroughCollection(someQueue, "Queue");

Stack<int> someStack = new Stack<int>();
someStack.Push(1); // add
someStack.Push(3);
someStack.Push(5);
someStack.Push(7);
someStack.Push(9);

int lastItemIn = someStack.Pop(); // remove
Console.WriteLine("Peek");
Console.WriteLine(someStack.Peek());

GoThroughCollection(someStack, "Stack");

#endregion