static void checkPhone (Dictionary<string,int> dic , string input)
{
    if(!dic.TryGetValue(input, out int result)){
        Console.WriteLine("Person not found");
        return;
    }
    Console.WriteLine (result);
}


Dictionary<string, int> phoneBook = new Dictionary<string, int>()
{
    {"petre", 111 },
    {"stevo", 222 },
    {"ЖАРЕ", 333 }
};

Console.WriteLine("Enter a name to find phonenumber");
string input = Console.ReadLine();
checkPhone(phoneBook,input);
