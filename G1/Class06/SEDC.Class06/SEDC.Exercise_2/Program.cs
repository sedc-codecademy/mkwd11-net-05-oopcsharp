using SEDC.Exercise_2.Models;

//Task 2
//Create a class Student that has properties: Name, Academy and Group
//Create an array with 5 new Students(objects)
//The user should enter a name and the user information should be displayed in the console if a user by that name exists
//If there is no such user it should show an error message




Student[] students = new Student[]
{
    new Student("Martin", "Web development", "G2"),
    new Student("Antonio", "Web development", "G1"),
    new Student("Petko", "Web development", "G4"),
    new Student("Trajko", "Web development", "G6"),
};

while (true)
{
    Console.WriteLine("Search student: ");
    string userInput = Console.ReadLine();

    for (int i = 0; i < students.Length; i++)
    {
        if (students[i].Name.ToLower() == userInput.ToLower())
        {
            Console.WriteLine($"Name: {students[i].Name} | Academy: {students[i].Academy} | Group: {students[i].Group}");
            break;
        }
        else if (i == students.Length - 1)
        {
            Console.WriteLine("There is no such student!");
        }
    }

    Console.WriteLine("Do you want to exit Y/N");
    string userChoice = Console.ReadLine();

    if(userChoice.ToLower() == "y")
    {
        break;
    }
}
