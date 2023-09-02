using System;
using System.Collections;

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

}