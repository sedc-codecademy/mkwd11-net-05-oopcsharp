
using System.Collections.Generic;

#region Dictionary

// DICTIONARY

using SEDC.Dictionaries.Models;

Dictionary<string, string> favouriteSongs = new Dictionary<string, string>();
favouriteSongs.Add("song1", "Have a nice day!");
favouriteSongs.Add("song2", "Wind of change");

// This is not allowed!
// Dictionary is a collection in which we can store items ONLY with 
// UNIQUE keys!
// Uncoment the line below to see the exception.

//favouriteSongs.Add("song2", "Nothing eles matters");


foreach (var item in favouriteSongs)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine($"The favourite songs dictionary has {favouriteSongs.Count} items in it.");


Dictionary<int, string> products = new Dictionary<int, string>();
products.Add(1111, "Bread");
products.Add(1123, "Milk");
products.Add(1122, "Eggs");

// ContainsKey() and ContainsValue() 
// Methods available on Dictionary in C# to find an item by key or by value

// TryGetValue() - method that finds a dictionary value by its key if there any, if not 
// only returns false.

Console.WriteLine(products[1123]);
if (products.ContainsValue("Bread"))
{
    string productItem = products[1111];
    bool isThereAnyBread = products.TryGetValue(11111, out string productItemBread);
    if (isThereAnyBread)
    {
        Console.WriteLine($"There is a product of {productItem} / {productItemBread} in the dictionary");
    }
}
else
{
    Console.WriteLine("No such product!");
}


Console.WriteLine("Before deleting eggs");
foreach (var item in products)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

products.Remove(1122);

Console.WriteLine("After deleting eggs");
foreach (var item in products)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
#endregion


#region Exercise 1

Dictionary<string, string> phoneBook = new Dictionary<string, string>();

// Keep in mind that in a phoneBook dictionary the phone number is UNIQUE and it is better to be a key in the 
// dictionary

//phoneBook.Add("070/222-333", "Martin");
//phoneBook.Add("075/221-343", "Tosho");
//phoneBook.Add("078/122-332", "Marija");
//phoneBook.Add("078/222-123", "Antonio");
//phoneBook.Add("078/222-455", "Antonio");


phoneBook.Add("Bob", "070/222-333");
phoneBook.Add("Ricky", "075/221-343");
phoneBook.Add("Martin", "078/122-332");
phoneBook.Add("Tosho", "078/222-123");
phoneBook.Add("Marija", "078/222-455");

void SearchPhoneBook(string name, Dictionary<string, string> phoneBook)
{
    if (phoneBook.ContainsKey(name))
    {
        Console.WriteLine($"The number for {name} is {phoneBook[name]}");
    }
    else
    {
        Console.WriteLine("No such number in the phonebook");
    }
}



//Console.WriteLine("Please search for a contact. Enter a name");
//string userInput = Console.ReadLine();

//SearchPhoneBook(userInput, phoneBook);


#endregion



#region Lists

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<string> names = new List<string>() { "Martin", "Petko", "Stanko" };

List<User> users = new List<User>()
{
    new User(1, "Martin", 29),
    new User(2, "Petko", 30),
    new User(3, "Stanko", 40),
    new User(4, "Branko", 33),
    new User(5, "Martin", 55),
    new User(6, "Stojadin", 27),
    new User(7, "Martin", 19)
};


Console.WriteLine("===== LISTS ======");
foreach (var user in users)
{
    Console.WriteLine($"{user.Id} - {user.Name}");
}

// Add() - method for adding new user in the List
users.Add(new User(4, "Tosho", 25));

Console.WriteLine("After adding user in the list");

foreach (var user in users)
{
    Console.WriteLine($"{user.Id} - {user.Name}");
}


// RemoveAt() - method that will remove an item from the array on a given index
users.RemoveAt(1);

// Will throw an exception
//users.RemoveAt(50);

// Remove() - method for removeing item from the List
names.Remove("Martin");

Console.WriteLine("List of names after removal of Martin");
foreach (var name in names)
{
    Console.WriteLine(name);
}
#endregion


#region Queue
Console.WriteLine("======= QUEUE ========");
Queue<int> intQueue = new Queue<int>();
intQueue.Enqueue(1);
intQueue.Enqueue(2);
intQueue.Enqueue(3);

foreach (var item in intQueue)
{
    Console.WriteLine(item);
}

// Dequeue() - method that will remove one item from the queue
// Not any, but the first inserted, because it removes by using FIFO method (First in First Out)
int dequeuedItem = intQueue.Dequeue();
Console.WriteLine("Dequeued item " + dequeuedItem);

Console.WriteLine("After Dequeue()");
foreach (var item in intQueue)
{
    Console.WriteLine(item);
}


#endregion


#region Stack
Console.WriteLine("======== STACK =======");
Stack<string> stringStack = new Stack<string>();
// Cannot remove from empty stack 
// it will throw an exception
//stringStack.Pop();

stringStack.Push("Hi");
stringStack.Push("Hello");
stringStack.Push("Bye");

Console.WriteLine("Before delete in the stack");
foreach (var item in stringStack)
{
    Console.WriteLine(item);
}


// Pop() - method that will remove an item from the stack
// Not any but the last inserted item, bcause it removes by using LIFO method (Last in First Out)
string removedStackItem = stringStack.Pop();

Console.WriteLine("After delete in the stack");

Console.WriteLine("This was removed from the stack" + removedStackItem);

foreach (var item in stringStack)
{
    Console.WriteLine(item);
}

Console.WriteLine(intQueue.Count);
Console.WriteLine(stringStack.Count);

#endregion


#region LINQ

// Where()
List<User> martins = users.Where(u => u.Name == "Martin").ToList();

foreach (User martin in martins)
{
    Console.WriteLine($"{martin.Name} {martin.Age}");
}


var filteredNames = names.Where(n => n == "Tosho").FirstOrDefault();
Console.WriteLine(filteredNames);


int sum = numbers.Sum();

double average = numbers.Average();


double averageAge = users.Average(x => x.Age);

users.Sum(user => user.Age);



Console.WriteLine($"The users has average of {averageAge} :)");


int petkosId = users.Where(user => user.Name == "Stojadin")
                    .Select(user => user.Id)
                    .First();

Console.WriteLine("Stojadin's id is: " + petkosId);

#endregion