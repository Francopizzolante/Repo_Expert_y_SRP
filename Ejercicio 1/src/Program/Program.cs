using System;
using System.Collections;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            Sector sectorA = new Sector("A");
            Sector sectorB = new Sector("B");
            Shelve shelveA7 = new Shelve("7");
            Shelve shelveB3 = new Shelve("3");
            sectorA.SectorBook(shelveA7);
            sectorA.SectorBook(shelveB3);

            shelveA7.ShelveBook(book1);
            shelveB3.ShelveBook(book2);

        }
    }
}