using System.Collections;

static void iterateCollection(IEnumerable collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
}

//Dictonary (Works  on Key/Value pair system. This system gives us the option to get values fromm collection by some key)
Dictionary<string, string> firstDictionary = new Dictionary<string, string>();
firstDictionary.Add("song1", "Have a nice day");
firstDictionary.Add("song2", "Wind of change");

bool firstKeyExists = firstDictionary.ContainsKey("song2");
bool thirdKeyExists = firstDictionary.ContainsKey("song3");
Console.WriteLine(firstKeyExists);
Console.WriteLine(thirdKeyExists);

Console.WriteLine("num of elements: " + firstDictionary.Count);
Console.WriteLine(firstDictionary["song1"]); //get value by key song1
Console.WriteLine(firstDictionary["song2"]); //get value by key song2

Dictionary<int, string> products = new Dictionary<int, string>()
{
    {123345, "Bread" },
    {566789, "Milk" },
    {345673, "Salt" }
};
iterateCollection(products); //Go trought the whole collection with our function created above
Console.WriteLine(products[566789]);
//Console.WriteLine(products[566711]); KeyNotFoundException
bool success = products.TryGetValue(66666, out string product);
Console.WriteLine(success);

//LIST - type and has no fixed lenght
List<int> integerList = new List<int>();
integerList.Add(3);
integerList.Add(245334543);
integerList.Add(6);
integerList.Add(9);
integerList.Remove(6);
Console.WriteLine(integerList[1]); //245334543
Console.WriteLine(integerList[2]);
integerList.RemoveAt(0);
Console.WriteLine(integerList[0]);
Console.WriteLine(integerList.Count);
Console.WriteLine("all in integerList:");
iterateCollection(integerList);

//ArrayList - non generic
//mixed (Accept all types and does not have constraint on number of elements)
ArrayList arrayList = new ArrayList() { "Hello", 2 };
arrayList.Add(true);
arrayList.Add(new string[] { "Hi", "Bye" });
Console.WriteLine(arrayList[2]);
Console.WriteLine(arrayList.Count);
arrayList.Remove(2);
Console.WriteLine(arrayList.Count);
//get the element with index 2 from the arrayList, then get element from the array with index 0
Console.WriteLine(((string[])arrayList[2])[0]);
Console.WriteLine("Elemets from arrayList: ");
iterateCollection(arrayList);

//QUEUE - First in first out
Queue<int> intQueue = new Queue<int>();
intQueue.Enqueue(5); //Add item to the Queue
intQueue.Enqueue(2); //Add item to the Queue
intQueue.Enqueue(7); //Add item to the Queue
iterateCollection(intQueue);
int firstNumber = intQueue.Peek(); //get the value of the first element
Console.WriteLine(firstNumber);
Console.WriteLine(intQueue.Count);
int firstMemeberOut = intQueue.Dequeue(); //get(and remove) the first element out of the queue
Console.WriteLine(firstMemeberOut);

firstNumber = intQueue.Peek();
Console.WriteLine(firstNumber);
Console.WriteLine(intQueue.Count);

//STACK - Last in First Out
Stack<string> ourStack = new Stack<string>();
ourStack.Push("Hello");
ourStack.Push("Hi");
ourStack.Push("Goodbye");
Console.WriteLine("Elements in Stack:");
iterateCollection(ourStack);
string lastMember = ourStack.Peek();
Console.WriteLine(lastMember);
Console.WriteLine(ourStack.Count);

string lastMemberOut = ourStack.Pop(); // get the last element out of the stack
Console.WriteLine(lastMemberOut);

lastMember = ourStack.Peek(); //get the value of the last element
Console.WriteLine(lastMember);
Console.WriteLine(ourStack.Count);





