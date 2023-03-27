using SEDC.VideoRental.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.VideoRental.Services.Services
{
    public class PromotionService
    {
        private MovieRepository _movieRepository;

        public PromotionService()
        {
            _movieRepository = new MovieRepository();
        }

        public string GetPromotion()
        {
            var maxId = _movieRepository.GetAllMovies().Max(_movie => _movie.Id);
            var rand = new Random();

            var promo = string.Empty;

            var movie = _movieRepository.GetMovieById(rand.Next(1, maxId));

            if(movie != null && movie.IsAvailable)
            {
                promo = string.Format("Now available {0}", movie.Title);
            }

            return promo;
        }
    }
}
