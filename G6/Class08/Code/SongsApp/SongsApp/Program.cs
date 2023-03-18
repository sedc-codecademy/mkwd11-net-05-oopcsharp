using SongsApp.Domain.Enums;
using SongsApp.Domain.Models;

Person person = new Person("Bob", "Bobsky", 22, Genre.Rock);
person.GetFavSongs();


person.Songs.Add(new Song("Song1", 3.20, Genre.Rock));
person.Songs.Add(new Song("Song2", 3.70, Genre.Rock));

person.GetFavSongs();