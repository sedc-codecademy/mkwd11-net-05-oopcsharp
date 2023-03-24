using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person()
        {
            FavouriteSongs = new List<Song>();
        }

        public void GetFavSongs()
        {
            if (FavouriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music!");
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} favourite songs:");
                foreach (Song song in FavouriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }
    }
}
