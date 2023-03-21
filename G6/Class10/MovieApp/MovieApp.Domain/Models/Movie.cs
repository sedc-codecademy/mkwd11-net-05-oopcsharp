

using MovieApp.Domain.Enums;

namespace MovieApp.Domain.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("Title must have a value");
            }
            Title = title;


            Genre = genre;
            if(rating < 1 || rating > 5)
            {
                throw new Exception($"Invalid rating value: {rating}");
            }
            Rating = rating;

            TicketPrice = rating * 5;
        }
    }
}
