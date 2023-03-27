

Console.WriteLine("Please enter a sentence");
string userInput = Console.ReadLine();

string[] words = userInput.Split(" ");
Console.WriteLine($"Your sentence has {words.Length} number of words");