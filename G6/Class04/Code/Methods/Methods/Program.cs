//Function (method) with no params and no return value

void PrintMessage()
{
    Console.WriteLine("Hello from our first method");
}
PrintMessage();

//Function (method) with params and no return value

void Greeting(string name)
{
    Console.WriteLine("Hello " + name);
}
Greeting("SEDC");
//Greeting(10);

void PrintInfo(string name, int age)
{
    Console.WriteLine(name + " is " + age + " years old");
}
PrintInfo("Ana", 22);

//Return value
string GetMessage()
{
    return "Hello from GetMessage";
}
string message = GetMessage();
Console.WriteLine("Message: " + message);

string CheckIfItISWeekend(bool isWeekend)
{
    if (isWeekend)
    {
        return "Yay! It is weekend!";
    }
    else
    {
        return "Sorry, it is a working day!";
    }
}
string weekendMessage = CheckIfItISWeekend(false);
Console.WriteLine(weekendMessage);