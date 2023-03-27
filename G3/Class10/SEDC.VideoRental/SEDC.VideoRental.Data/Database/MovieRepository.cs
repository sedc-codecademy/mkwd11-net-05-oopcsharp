using SEDC.VideoRental.Data.Enums;
using SEDC.VideoRental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.VideoRental.Data.Database
{
    public class MovieRepository : InMemoryDatabase
    {
        public List<Movie> GetAllMovies()
        {
            return Movies;
        }

        public List<Movie> GetByGenre(Genre genre)
        {
            return Movies.Where(_movie => _movie.Genre == genre).ToList();
        }

        public List<Movie> OrderByGenre()
        {
            return Movies.OrderBy(_movie => _movie.Genre).ToList();
        }

        public List<Movie> OrderByReleaseDate(bool desc = false)
        {
            if (desc)
            {
                return Movies.OrderByDescending(_movie => _movie.ReleaseDate).ToList();
            }
            return Movies.OrderBy(_movie => _movie.ReleaseDate).ToList();
        }

        public List<Movie> GetByYear(int year)
        {
            return Movies.Where(_movie => _movie.ReleaseDate.Year == year).ToList();
        }

        public List<Movie> GetAvailableMovies()
        {
            return Movies.Where(_movie => _movie.IsAvailable).ToList();
        }

        public List<Movie> OrderByAvailability(bool desc = false)
        {
            if (desc)
            {
                return Movies.OrderByDescending(_movie => _movie.IsAvailable).ToList();
            }
            return Movies.OrderBy(_movie => _movie.IsAvailable).ToList();
        }

        public List<Movie> SearchMoviesByName(string namePart)
        {
            return Movies.Where(_movie => _movie.Title.ToLower().Contains(namePart.ToLower())).ToList();
        }
        
        // TODO: PART 2
        public Movie GetMovieById(int idSelected)
        {
            return Movies.FirstOrDefault(_movie => _movie.Id == idSelected);
        }

        // TODO: END PART 2
    }
}
