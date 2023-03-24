namespace Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GenreEnum FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, GenreEnum favoriteMusicType)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = new List<Song>();

            Random rnd = new Random();
            Id = rnd.Next();
        }
        public Person()
        {
            
        }
    }
}
