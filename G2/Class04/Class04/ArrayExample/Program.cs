//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Recap from Class 03
//int[] newArray = new int[5];
//int sum = 0;
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Enter number");
//    newArray[i] = Convert.ToInt32(Console.ReadLine());
//    sum += newArray[i];

//}
//Console.WriteLine($"The sum of the array is {sum}");

//6th exercise

string[] namesArray = new string[50];
int counter = 0;

while (true)
{
    Console.WriteLine("Enter a name: ");
    string name = Console.ReadLine();
    namesArray[counter] = name;
    counter++;

    Console.WriteLine("If you want to enter another name please enter Y, otherwise enter N");
    string userResponse = Console.ReadLine();
    if (userResponse.ToUpper() == "N")
    {
        break;
    }
    //    for(int i = 0;i< counter; i++)
    //    {
    //        Console.WriteLine(namesArray[i]);
    //    }

}
Console.WriteLine("Names you have entered are: ");
foreach (string nameFromArray in namesArray)
{
    Console.WriteLine(nameFromArray);
}