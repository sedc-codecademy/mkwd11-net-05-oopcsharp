//Task 3
//You are given the following string
//"The whole group of G2 loves C#.They find learning this language fun and easy!".
//Print the text after the ".", using string methods.


string message = "The whole group of G2 loves C#.They find learning this language fun and easy!";

// Approach 1
Console.WriteLine(message.Split(".")[1]);

// Approach 2
string[] messageSplitted = message.Split(".");
Console.WriteLine(messageSplitted[messageSplitted.Length - 1]);