using SongsApp.Domain.Enums;
using SongsApp.Domain.Models;

Person jerry = new Person("Jerry", "Jersky", 33, Genre.Hip_Hop);
Person bob = new Person("Bob", "Bobsky", 23, Genre.Classical);
Person kate = new Person("Kate", "Bobsky", 27, Genre.Rock);
Person bill = new Person("Bill", "Billsky", 27, Genre.Techno);

List<Person> fans = new List<Person>
            {
                jerry,
                bob,
                kate,
                bill
            };

Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
Song song2 = new Song("Stairway To Heaven", 480, Genre.Rock);
Song song3 = new Song("Riders On The Storm", 430, Genre.Rock);
Song song4 = new Song("Not Fade Away", 108, Genre.Rock);
Song song5 = new Song("Breaking Glass", 111, Genre.Rock);
Song song6 = new Song("Welcome To The Jungle", 275, Genre.Rock);
Song song7 = new Song("Walk Of Life", 266, Genre.Rock);
Song song8 = new Song("Smoke on the Water", 340, Genre.Rock);
Song song9 = new Song("93 'til Infinity", 209, Genre.Techno);
Song song10 = new Song("Fight the Power", 321, Genre.Techno);
Song song11 = new Song("The Message", 363, Genre.Techno);
Song song12 = new Song("Butterfly Effect", 213, Genre.Techno);
Song song13 = new Song("No Fear", 182, Genre.Techno);
Song song14 = new Song("Hereditary", 340, Genre.Techno);
Song song15 = new Song("Bounce Back", 226, Genre.Techno);
Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
Song song17 = new Song("Canon in D major", 376, Genre.Classical);
Song song18 = new Song("Swan Lake", 461, Genre.Classical);
Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
Song song22 = new Song("Carmen Suite No.1", 721, Genre.Classical);
Song song23 = new Song("Planet E", 420, Genre.Techno);
Song song24 = new Song("Phasor", 368, Genre.Techno);
Song song25 = new Song("Counting Comets", 242, Genre.Techno);
Song song26 = new Song("Cold Summer", 358, Genre.Techno);
Song song27 = new Song("Destroyer", 359, Genre.Techno);
Song song28 = new Song("Phalanx", 307, Genre.Techno);
Song song29 = new Song("Vision", 693, Genre.Techno);
Song song30 = new Song("Chain Reaction", 181, Genre.Techno);

List<Song> songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                                                song8, song9, song10, song11, song12, song13, song14,
                                                song15, song16, song17, song18, song19, song20,
                                                song21, song22, song23, song24, song25, song26, song27, song28, song29, song30 };


//Find Jerry, add songs that start with B
Person personJerry = fans.FirstOrDefault(x => x.FirstName.Equals("Jerry", StringComparison.InvariantCultureIgnoreCase));
if(personJerry == null)
{
    Console.WriteLine("Jerry not found!");
}

personJerry.Songs = songs.Where(x => x.Title.StartsWith("B")).ToList();
personJerry.GetFavSongs();


Person personMaria = fans.FirstOrDefault(x => x.FirstName.ToLower() == "maria");
if(personMaria == null)
{
    Console.WriteLine("Maria not found!");
}

//all songs with length more than 6 mins (360s)
songs.Where(x => x.Length > 360).ToList();

//find Jane, add all songs with Genre Rock

//Person personJane = fans.FirstOrDefault(x => x.FirstName.ToLower() == "jane");
//if (personJane == null)
//{
//    Console.WriteLine("jane not found!");
//}


Person personJane = FindPerson(fans, "Jane");
if(personJane != null)
{
    personJane.Songs = songs.Where(x => x.Genre == Genre.Rock).ToList();
}

Person personKate = FindPerson(fans, "Kate");
if (personKate != null)
{
    personKate.Songs = songs.Where(x => x.Genre == Genre.Rock).ToList();
}

Person personBob = FindPerson(fans, "Bob");
if(personBob != null)
{
    //all songs shorter than 3 mins and of genre Hip-Hop
    personBob.Songs = songs.Where(x => x.Length < 180 && x.Genre == Genre.Hip_Hop).ToList();
    personBob.GetFavSongs();
}


//find all the people with more than 4 songs
List<Person> filteredPeople = fans.Where(x => x.Songs.Count >= 4).ToList();
foreach(Person person in filteredPeople)
{
    person.GetFavSongs();
}


//Bonus
Person FindPerson(List<Person> fansList, string firstName)
{
    Person person =  fansList.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
    if (person == null)
    {
        Console.WriteLine($"{firstName} not found!");
       
    }

    return person;
}