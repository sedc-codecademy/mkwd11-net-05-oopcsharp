namespace Class06_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];

            string[] messagesOfUser1 = new string[] { "Message 1 of user1", "Message 2 of user1" };
            User user1 = new User(1, "user1", "user1Password", messagesOfUser1);

            users[0] = user1;

            users[1] = new User(2, "user2", "user2Password", new string[] { "Message 1 of user2", "Message 2 of user2", "Message 3 of user2" });

            users[2] = new User(3, "user3", "user3Password", new string[] { "Message 1 of user3" });

            while (true)
            {
                string input;
                while (true)
                {
                    Console.WriteLine("Please choose an option\n\t1. Log-in\n\t2. Register");

                    input = Console.ReadLine();

                    if (input == "1" || input == "2")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("We only support options 1 & 2, so please choose one of them");
                    }
                }

                if (input == "1")
                {
                    Console.Write("Username:");
                    string inputUsername = Console.ReadLine();

                    Console.Write("Password:");
                    string inputPassword = Console.ReadLine();

                    User foundUser = null;
                    foreach (User u in users)
                    {
                        if (u.Username == inputUsername && u.CorrectPassword(inputPassword))
                        {
                            foundUser = u;
                            break;
                        }
                    }

                    if (foundUser == null)
                    {
                        Console.WriteLine($"No user was found with username {inputUsername} and password {inputPassword}");
                    }
                    else
                    {
                        Console.WriteLine(foundUser.GetInfo());
                    }
                } else if(input == "2")
                {
                    Console.Write("Please enter username:");
                    string username = Console.ReadLine();

                    Console.Write("Please enter a password:");
                    string password = Console.ReadLine();

                    string[] newUserMessages = new string[0];

                    while(true)
                    {
                        Console.WriteLine("Please write your message:");
                        string messageInput = Console.ReadLine();

                        Array.Resize(ref newUserMessages, newUserMessages.Length + 1);
                        newUserMessages[newUserMessages.Length - 1] = messageInput;

                        Console.WriteLine("If you want to add another message press Y");
                        string proceedInput = Console.ReadLine();

                        if(proceedInput != "Y")
                        {
                            break;
                        }
                    }

                    int id = users.Length + 1;
                    User newUser = new User(id, username, password, newUserMessages);

                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = newUser;
                }
            }
        }
    }
}