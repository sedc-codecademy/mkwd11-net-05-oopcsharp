

using SongsApp.Domain.Enums;

namespace SongsApp.Domain.Models
{
    public class Song
    {
        public string Title { get; set; }
        public double Length { get; set; }
        public Genre Genre { get; set; }

        public Song(string title, double length, Genre genre)
        {
            //TODO validation
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}
