string[] names = new string[0]; //empty array
int counter = 0;

while (true)
{
    Console.WriteLine("Enter a name");
    string name = Console.ReadLine();

    Array.Resize(ref names, names.Length + 1);

    names[counter] = name;
    counter++;
   
    Console.WriteLine("Enter n if you want to stop");
    string input = Console.ReadLine();
    if(input == "N" || input == "n")
    {
        break;
    }
}