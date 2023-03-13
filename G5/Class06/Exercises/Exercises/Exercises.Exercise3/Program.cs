using Exercises.Exercise3.Classes;

#region Methods

User FindUser(User[] users, string username, string password)
{
    foreach (User user in users)
    {
        if (user.Username.ToLower() == username.ToLower() && user.Password == password) return user;
    }
    return null;
}

void Login(User[] users, string username, string password)
{
    User user = FindUser(users, username, password);
    if (user == null)
    {
        Console.WriteLine("User not found!");
        return;
    }
    Console.WriteLine("-------------------------");
    Console.WriteLine($"Welcome {user.Username}!");
    Console.WriteLine("-------------------------");
    Console.WriteLine("Your messages:");
    foreach (string message in user.messages)
    {
        Console.WriteLine(message);
    }
    Console.WriteLine("-------------------------");
}

void Register(User[] users, string username, string password, int id)
{
    User user = FindUser(users, username, password);
    if (user != null)
    {
        Console.WriteLine("User already exists!");
        return;
    }
    Array.Resize(ref users, users.Length + 1);
    users[users.Length - 1] = new User() { Id = id, Username = username, Password = password };
    Console.WriteLine("Successfully registered!");
    Console.WriteLine("-------------------------");
    Console.WriteLine("Users registered so far:");
    Console.WriteLine("-------------------------");
    foreach (User u in users)
    {
        Console.WriteLine($"Id: {u.Id}, Username: {u.Username}");
    }
    Console.WriteLine("-------------------------");
}

bool UsersUI(User[] users)
{
    Console.WriteLine("Choose: \n1) Log in \n2)Register");
    int choice;
    bool isNumber = int.TryParse(Console.ReadLine(), out choice);
    if (!isNumber)
    {
        Console.WriteLine("That was not a number! Try again.");
        return false;
    }
    switch (choice)
    {
        case 1:
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Login(users, username, password);
            return true;
        case 2:
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Username: ");
            string newUsername = Console.ReadLine();
            Console.Write("Enter Password: ");
            string newPassword = Console.ReadLine();
            Register(users, newUsername, newPassword, id);
            return true;
        default:
            Console.WriteLine("Please enter 1 or 2");
            return false;
    }
}
#endregion


User[] users = new User[]
{
                new User(){Id = 24, Username = "Bob23", Password = "mysuperpass", messages = new string[]{"Hey bob! Nice shirt.", "Call me pls!" } },
                new User(){Id = 12, Username = "Jill_awesome", Password = "123456", messages = new string[]{"How are ya? Call me", "When will you go to work?", "Your card is ready!" }},
                new User(){Id = 5, Username = "GregGregsky", Password = "lozinka", messages = new string[]{"Come to my party tomorrow!", "Drunk message. Please don't take it seriously." }}
};
while (!UsersUI(users)) ;
Console.ReadLine();