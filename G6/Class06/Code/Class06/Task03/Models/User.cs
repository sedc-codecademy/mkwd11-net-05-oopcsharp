

namespace Task03.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }
		
		public User(){

            //Messages = new string[0];

            Messages = new string[1];
            Messages[0] = "Welcome";
		}

    }
}
