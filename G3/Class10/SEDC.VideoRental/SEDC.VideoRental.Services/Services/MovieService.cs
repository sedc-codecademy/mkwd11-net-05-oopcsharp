using SEDC.VideoRental.Data.Database;
using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Loaders;
using SEDC.VideoRental.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SEDC.VideoRental.Services.Services
{
    public class MovieService
    {

        // TODO Refactor to use InMemoryDatabase Users :)
        // TODO: PART 2
        private readonly MovieRepository _movieRepository;
        public MovieService()
        {
            _movieRepository = new MovieRepository();
        }

        public void ViewMovieList(User user)
        {
            string errorMessage = string.Empty;
            var movies = new List<Movie>();
            bool isFinished = false;
            while (!isFinished)
            {
                Screen.ClearScreen();
                Screen.ErrorMessage(errorMessage);
                if(movies.Count != 0)
                {
                    PrintMoviesInfo(movies);
                }
                else
                {
                    Console.WriteLine("No videos available with that filtering options");
                }
                Screen.OrderingMenu();
                var selection = InputParser.ToInteger(0, 9);
                switch (selection)
                {
                    case 1:
                        movies = _movieRepository.GetAllMovies();
                        break;
                    case 2:
                        movies = _movieRepository.OrderByGenre();
                        break;
                    case 3:
                        // TODO: Get videos by genre
                        var genre = InputParser.ToGenre();
                        movies = _movieRepository.GetByGenre(genre);
                        break;
                    case 4:
                        movies = _movieRepository.OrderByReleaseDate();
                        break;
                    case 5:
                        // TODO: Get movies by year of release
                        var year = InputParser.ToInteger(
                                _movieRepository.GetAllMovies().Min(_movie => _movie.ReleaseDate.Year),
                                DateTime.Now.Year - 1
                            );
                        movies = _movieRepository.GetByYear(year);
                        break;
                    case 6:
                        movies = _movieRepository.OrderByAvailability();
                        break;
                    case 7:
                        movies = _movieRepository.GetAvailableMovies();
                        break;
                    case 8:
                        // TODO: Search videos by title
                        var titlePart = Console.ReadLine();
                        movies = _movieRepository.SearchMoviesByName(titlePart);
                        break;
                    case 9:
                        try
                        {
                            RentMovie(user);
                        }
                        catch (Exception ex)
                        {
                            errorMessage = ex.Message;
                        }
                        break;
                    case 0:
                        isFinished = !isFinished;
                        break;
                }
            }
        }

        private void RentMovie(User user)
        {
            Console.Write("Enter movie id: ");
            var idSelected = InputParser.ToInteger(
                _movieRepository.GetAllMovies().Min(_movie => _movie.Id),
                _movieRepository.GetAllMovies().Max(_movie => _movie.Id));

            var movie = _movieRepository.GetMovieById(idSelected);
            if (movie != null)
            {
                var listOfRentedMovieIds = user.RentedMovies.Select(rental => rental.Movie.Id).ToList();
                if (listOfRentedMovieIds.Contains(idSelected))
                {
                    throw new Exception($"Already rented {movie.Title} please return it first");
                }

                if (!movie.IsAvailable)
                {
                    throw new Exception($"Movie {movie.Title} is not available at the moment.");
                }
                // Confirmation
                Console.WriteLine($"Are you sure you want to rent {movie.Title}? y/n");
                bool confirm = InputParser.ToConfirm();
                if (!confirm)
                {
                    return;
                }
                // End confirmation

                Console.WriteLine("Renting movie please wait...");
                LoadingHelpers.Spiner();
                movie.Quantity--;
                if (movie.Quantity == 0)
                {
                    movie.IsAvailable = !movie.IsAvailable;
                }
                user.RentedMovies.Add(new RentalInfo(movie));
                Console.WriteLine("Successfuly rented movie");
                Thread.Sleep(3000);
            }
            else
            {
                throw new Exception($"No movie was fount with {idSelected} id");
            }
        }

        private void PrintMoviesInfo(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                string availability = movie.IsAvailable ? "Yes" : "No";
                Console.WriteLine(string.Format("Rent id: {0} Title: {1} Release date: {2} Genre: {3} Available: {4}, Quantity: {5}",
                    movie.Id, movie.Title, movie.ReleaseDate.ToString("MMMM dd yyyy"), movie.Genre, availability, movie.Quantity));
            }
        }
        // TODO: END OF PART 2

        // TODO: PART 3
        
        public void ViewRentedVideos(User user)
        {
            string errorMessage = string.Empty;
            var rentals = user.RentedMovies;
            bool isActive = false;
            while (!isActive)
            {
                try
                {
                    Screen.ClearScreen();
                    Screen.ErrorMessage(errorMessage);
                    if (rentals.Count != 0)
                    {
                        PrintMoviesInfo(rentals.Select(_rentals => _rentals.Movie).ToList());
                    }
                    else
                    {
                        Console.WriteLine("You have not rented any videos");
                    }
                    Screen.RentedMenu();
                    int selection = InputParser.ToInteger(0, 2);
                    switch (selection)
                    {
                        case 1:
                            rentals = user.RentedMovies;
                            break;
                        case 2:
                            ReturnMovie(user);
                            break;
                        case 0:
                            isActive = !isActive;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;
                }
            }
        }

        private void ReturnMovie(User user)
        {
            if(user.RentedMovies.Count == 0)
            {
                Console.WriteLine("You dont have any rented videos");
                return;
            }
            Console.WriteLine("Enter movie id in order to return a video");
            int movieId = InputParser.ToInteger(1, int.MaxValue);

            var rental = user.RentedMovies.FirstOrDefault(_rental => _rental.Movie.Id == movieId);
            Console.WriteLine("Processing");
            LoadingHelpers.Spiner();
            if (rental != null)
            {
                rental.DateReturned = DateTime.Now;
                var movie = _movieRepository.GetMovieById(movieId);
                if (movie.Quantity == 0)
                {
                    movie.IsAvailable = !movie.IsAvailable;
                }
                movie.Quantity += 1;
                
                user.RentedMoviesHistory.Add(rental);
                user.RentedMovies.Remove(rental);
                
                Console.WriteLine("Successfuly returned.");
                Thread.Sleep(3000);
                return;
            }

            throw new Exception("You do not have that movie rented. Please enter valid movie id");
        }

        public void ViewRentedHistoryVideos(User user)
        {
            if (user.RentedMoviesHistory.Count == 0)
            {
                throw new Exception("You do not have any videos rented history.");
            }

            foreach (var rental in user.RentedMoviesHistory)
            {
                Console.WriteLine($"{rental.Movie.Title} rented from {rental.DateRented} to {rental.DateReturned}");
            }

            Console.WriteLine("To go back press 0");
            int selection = InputParser.ToInteger(0, 0);
            if(selection == 0)
            {
                return;
            }
        }

        // TODO: END PART 3
    }
}
