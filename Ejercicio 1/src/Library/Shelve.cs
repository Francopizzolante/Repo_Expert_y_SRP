using System;
using System.Collections;

namespace Ucu.Poo.Expert
{
    public class Shelve
    {
        public string Name { get; set; }

        public ArrayList Books { get; set; }
        public Shelve(string name)
        {
            this.Name = name;
            this.Books = new ArrayList();
        }

        public void ShelveBook(Book book)
        {
            this.Books.Add(book);
        }
    }
}