using Exercise2.Entities;

Person person = new Person()
{
    FirstName = "John",
    LastName = "Peterson",
    Age = 20,
    Id = 1
};

person.FavouriteSongs.Add(new Song()
{
    Genre = Genre.Rock,
    Length = 3.3,
    Title = "Have a nice day"
});
person.FavouriteSongs.Add(new Song()
{
    Genre = Genre.Classical,
    Length = 5,
    Title = "Eine kleine Nachtmusik"
});
person.GetFavSongs();