using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOPClasses_1.Models
{
    public class Book
    {

        public Book()
        {
            ISBN = SetISBN();
        }

        public Book(string title)
        {
            Title = title;
            ISBN = SetISBN();
        }

        public Book(string title, string author, string isbn, int numOfPages, string genre)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            NumberOfPages = numOfPages;
            Genre = genre;
        }


        public string Title { get; set; }
        public string Author { get; set; }
        private string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public string Genre { get; set; }


        public string GetBookInfo()
        {
            return $"{Title} - {Author} | Genre: {Genre} | Pages: {NumberOfPages}";
        }


        private string SetISBN()
        {
            return new Random().Next(10000, 99999).ToString();
        }

    }
}
