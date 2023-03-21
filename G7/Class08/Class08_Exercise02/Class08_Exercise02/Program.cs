using Models;

namespace Class08_Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> fansArray = new List<Person>();

            //fans
            Person jerry = new Person("Jerry", "Tompson", 78, GenreEnum.Rock);
            Person stefan = new Person("Stefan", "Stefanoski", 28, GenreEnum.Techno);
            Person maria = new Person("Maria", "Campbel", 43, GenreEnum.Classical);
            Person jane = new Person("Jane", "Doe", 28, GenreEnum.Techno);

            //songs
            Song song1 = new Song("Bohemian Rhapsody", 367, GenreEnum.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, GenreEnum.Rock);
            Song song3 = new Song("Riders On The Storm", 430, GenreEnum.Rock);
            Song song4 = new Song("Not Fade Away", 108, GenreEnum.Rock);
            Song song5 = new Song("Breaking Glass", 111, GenreEnum.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, GenreEnum.Rock);
            Song song7 = new Song("Walk Of Life", 266, GenreEnum.Rock);
            Song song8 = new Song("Smoke on the Water", 340, GenreEnum.Rock);
            Song song9 = new Song("93 'til Infinity", 209, GenreEnum.Techno);
            Song song10 = new Song("Fight the Power", 321, GenreEnum.Techno);
            Song song11 = new Song("The Message", 363, GenreEnum.Techno);
            Song song12 = new Song("Butterfly Effect", 213, GenreEnum.Techno);
            Song song13 = new Song("No Fear", 182, GenreEnum.Techno);
            Song song14 = new Song("Hereditary", 340, GenreEnum.Techno);
            Song song15 = new Song(" Bounce Back", 226, GenreEnum.Techno);
            Song song16 = new Song("The Four Seasons", 2520, GenreEnum.Classical);
            Song song17 = new Song("Canon in D major", 376, GenreEnum.Classical);
            Song song18 = new Song("Swan Lake", 461, GenreEnum.Classical);
            Song song19 = new Song("Symphony No. 5", 425, GenreEnum.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, GenreEnum.Classical);
            Song song21 = new Song("The Magic Flute", 458, GenreEnum.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, GenreEnum.Classical);
            Song song23 = new Song("Planet E", 420, GenreEnum.Techno);
            Song song24 = new Song("Phasor", 368, GenreEnum.Techno);
            Song song25 = new Song("Counting Comets", 242, GenreEnum.Techno);
            Song song26 = new Song("Cold Summer", 358, GenreEnum.Techno);
            Song song27 = new Song("Destroyer", 359, GenreEnum.Techno);
            Song song28 = new Song("Phalanx", 307, GenreEnum.Techno);
            Song song29 = new Song("Vision", 693, GenreEnum.Techno);
            Song song30 = new Song("Chain Reaction", 181, GenreEnum.Techno);
            Song song31 = new Song("", 181, GenreEnum.Techno);

            List<Song> songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                                                song8, song9, song10, song11, song12, song13, song14,
                                                song15, song16, song17, song18, song19, song20,
                                                song21, song22, song23, song24, song25, song26, song27, song28, song29, song30, song31 };

            fansArray.Add(jerry);
            fansArray.Add(stefan);
            fansArray.Add(maria);
            fansArray.Add(jane);
        }
    }
}