

using SongsApp.Domain.Enums;

namespace SongsApp.Domain.Models
{
    public class Person
    {
        private int _id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusicType { get; set; }
        public List<Song> Songs { get; set; } //list of Song objects, default value is null!!!!

        public Person(string firstName, string lastName, int age, Genre favouriteType)
        {
            FirstName = firstName; 
            LastName = lastName;
            Age = age;
            FavouriteMusicType = favouriteType;
            _id = new Random().Next(1, 10000);

            ///!!!!!
            Songs = new List<Song>();
        }

        public void GetFavSongs()
        {
            Console.WriteLine($"{FirstName}'s favourite songs:");
            foreach(Song song in Songs)
            {
                Console.WriteLine(song.Title);
            }
        }
    }
}
