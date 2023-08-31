using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {

        public string Title { get; }
        public string Author { get; }
        public string Code { get; }
        public string LibrarySector { get; set; }
        public string LibraryShelve { get; set; }

        public Book(string title, string author, string code)
        {
            Title = title;
            Author = author;
            Code = code;
        }
    }

    public class Library
    {
        public string Sector { get; set; }
        public string Shelve { get; set; }

        public void ShelveBook(Book book, string sector, string shelve)
        {
            book.LibrarySector = sector;
            book.LibraryShelve = shelve;
        }
    }
}