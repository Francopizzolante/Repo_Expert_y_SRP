using System;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            
            Library library = new Library();
            library.ShelveBook(book1, "A", "7");
            library.ShelveBook(book2, "B", "3"); 

            Console.WriteLine($"Book Title: {book1.Title}, Author: {book1.Author}, Code: {book1.Code}, LibrarySector:{book1.LibrarySector}, LibraryShelve:{book1.LibraryShelve}"); //Esta linea es de control de funcionamiento, omitirla

        }
    }
}