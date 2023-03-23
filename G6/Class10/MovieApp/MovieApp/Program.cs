using MovieApp.Domain.Enums;
using MovieApp.Domain.Models;

//try
//{
//    Movie movie = new Movie("Titanic", Genre.Drama, 10);
//}
//catch(Exception e)
//{
//    Console.WriteLine("An error occurred");
//    Console.WriteLine(e.Message);
//}

try
{
    Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
    Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
    Movie movie3 = new Movie("Saw", Genre.Horror, 4);
    Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
    Movie movie5 = new Movie("Rambo", Genre.Action, 4);
    Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
    Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
    Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
    Movie movie9 = new Movie("Passengers", Genre.Sci_Fi, 4);
    Movie movie10 = new Movie("Interstellar", Genre.Sci_Fi, 4);
    List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
    Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
    Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
    Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
    Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
    Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
    Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
    Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
    Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
    Movie movie19 = new Movie("Inception", Genre.Sci_Fi, 4);
    Movie movie20 = new Movie("Avatar", Genre.Sci_Fi, 4);
    List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };


    Cinema cinema1 = new Cinema("Cineplex");
    cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
    cinema1.Movies = MovieSet1;
    Cinema cinema2 = new Cinema("Milenium");
    cinema2.Halls = new List<int>() { 1, 2 };
    cinema2.Movies = MovieSet2;

    Console.WriteLine("Choose a cinema");
    Console.WriteLine($"1) {cinema1.Name}");
    Console.WriteLine($"2) {cinema2.Name}");

    string input = Console.ReadLine();
    int cinemaInput = int.Parse(input); //Potential FormatException


    //find the appropriate cinema
    Cinema cinema;
    if(cinemaInput == 1)
    {
        cinema = cinema1;
    }
    else if(cinemaInput == 2)
    {
        cinema = cinema2;
    }
    else
    {
        throw new Exception("Invalid cinema option");
    }

    //choose what to do
    Console.WriteLine("What do you want to search for?");
    Console.WriteLine("1) All movies");
    Console.WriteLine("2) Movies by genre");

    int moviesInput = int.Parse(Console.ReadLine()); //Potential FormatException

    if(moviesInput == 1)
    {
        Console.WriteLine("Enter the title of the movie you want to watch");
        foreach(Movie movie in cinema.Movies)
        {
            Console.WriteLine(movie.Title);
        }

        string movieInput = Console.ReadLine();
        Movie movieToWatch = cinema.Movies.FirstOrDefault(x => x.Title == movieInput);

        cinema.WatchMovie(movieToWatch);
    }
    else if(moviesInput == 2)
    {
        Console.WriteLine("Enter genre:");
        Console.WriteLine("1) Comedy");
        Console.WriteLine("2) Horror");
        Console.WriteLine("3) Action");
        Console.WriteLine("4) Drama");
        Console.WriteLine("5) SciFi");

        int inputGenre = int.Parse(Console.ReadLine());

        //Genre genre = 1; //ERROR , DIFFERENT DATA TYPES
        Genre genre = Genre.Comedy;
        Genre secondGenre = (Genre)1; //(Genre)1 => Genre.Comedy

        //if(inputGenre == 1)
        //{
        //    List<Movie> filteredMovies = cinema.Movies.Where(x => x.Genre == Genre.Comedy).ToList();
        //}

        //we can't compare value of type Genre with value of type int. We need to cast (change the data type of
        //inputGenre from int to Genre, so we compare Genre with Genre
        List<Movie> filteredMovies = cinema.Movies.Where(x => x.Genre == (Genre)inputGenre).ToList();
        Console.WriteLine("Enter the title of the movie you want to watch");
        foreach (Movie movie in filteredMovies)
        {
            Console.WriteLine(movie.Title);
        }
        string movieInput = Console.ReadLine();
        Movie movieToWatch = cinema.Movies.FirstOrDefault(x => x.Title == movieInput);

        cinema.WatchMovie(movieToWatch);

    }
}
catch(FormatException e)
{
    Console.WriteLine("Input was with invalid format");
}
catch(Exception e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
