using System;

namespace SEDC.VideoRental.Data.Models
{
    public class RentalInfo
    {

        //TODO: PART 3
        public Movie Movie { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime DateReturned { get; set; }

        public RentalInfo(Movie movie)
        {
            Movie = movie;
            DateRented = DateTime.Now;
            DateReturned = DateTime.Now.AddMonths(-1);
        }
    }
}
