

namespace MovieApp.Domain.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema()
        {
            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public Cinema(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("You must provide a name for the cinema");
            }
            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public void WatchMovie(Movie movie)
        {
            //if(movie == null)
            //{
            //    Console.WriteLine("We don't have that movie");
            //}
            //else
            //{
            //    Console.WriteLine($"YOu are now watching {movie.Title}");
            //}

            if(movie == null)
            {
                throw new Exception("You entered a movie that we don't have");
            }
            Console.WriteLine($"YOu are now watching {movie.Title}");
        }
    }
}
