//Arrays
using System.Collections;

int[] intsArray = new int[3]; //allocate memory for 3 ints
string[] stringsArray = new string[] { "Hello", "Bye" };
Console.WriteLine("====Array====");
foreach (string str in stringsArray)
{
    Console.WriteLine(str);
}

//ArrayList (accepts all types, can have mixed array lists, doesn't have constraint on number of members)
Console.WriteLine("====ArrayList====");
ArrayList arrayList = new ArrayList(); //empty
ArrayList secondArrayList = new ArrayList { "Hello", 5, true };
secondArrayList.Add("Bye");
secondArrayList.Add('a');
secondArrayList.Remove(5);
foreach(var item in secondArrayList)
{
    Console.WriteLine(item);
}

//List (all members must be of same type, doesn't have constraint on number of members)
Console.WriteLine("====List====");
List<int> emptyListOfInts = new List<int>(); //emptyListOfInts
List<int> listOfInts = new List<int> { 2, 88, 9 };

listOfInts.Add(100); //add 100 to the list
listOfInts.Add(-10);
listOfInts.Remove(88); //remove 88 from the list
listOfInts.RemoveAt(0); //remove the member on index 0;
Console.WriteLine(listOfInts[0]); //get the member on index 0
Console.WriteLine($"Number of members in listOfInts: {listOfInts.Count}");

foreach (int number in listOfInts)
{
    Console.WriteLine(number);
}

//Dictionary (works with key-value pairs), no indicies
Console.WriteLine("====Dictionary====");
Dictionary<int, string> products = new Dictionary<int, string>()
{
    {111, "potato" },
    {222, "bread" },
    {333, "milk" }
};

Console.WriteLine(products[222]); //get the value for key 222

products.Add(444, "cookies");
products.Remove(333);
foreach(var item in products)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

//Queue (First in First Out)
Console.WriteLine("====Queue====");
Queue<int> ourQueue = new Queue<int>();
ourQueue.Enqueue(100); //Add 100 to the end of the queue
ourQueue.Enqueue(2); //Add 2 to the end of the queue
ourQueue.Enqueue(25); //Add 25 to the end of the queue

int firstMember = ourQueue.Dequeue(); //remove and return the first member

int readFirstMember = ourQueue.Peek(); // only get the value of the first member, but do not remove it

Console.WriteLine(readFirstMember);
Console.WriteLine(ourQueue.Count);

foreach(int item in ourQueue)
{
    Console.WriteLine(item);
}

//Stack (Last In First Out)
Console.WriteLine("====Stack====");
Stack<string> ourStack = new Stack<string>();
ourStack.Push("Hello"); //add member to the end of the stack
ourStack.Push("Bye"); //add member to the end of the stack
ourStack.Push("Welcome"); //add member to the end of the stack

string lastMember = ourStack.Pop(); //read and remove the last member
string currentLastMember = ourStack.Peek(); //read but dont' remove the last member

Console.WriteLine(ourStack.Count);
foreach(string item in ourStack)
{
    Console.WriteLine(item);
}





