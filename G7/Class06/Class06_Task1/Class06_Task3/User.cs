namespace Class06_Task3
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public string[] Messages { get; set; }

        public User(int id, string userName, string password, string[] messages)
        {
            Id = id;
            Username = userName;
            Password = password;
            Messages = messages;
        }

        public bool CorrectPassword(string password)
        {
            //if (Password == password)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return Password == password;
        }

        public string GetInfo()
        {
            string text = $"Welcome {Username}. Here are your messages:\n";

            foreach(string message in Messages)
            {
                text += $"\t- {message}\n";
            }

            return text;
        }
    }
}
