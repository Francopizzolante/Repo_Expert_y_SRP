using System;
using System.Collections;

namespace Ucu.Poo.Expert
{
    public class Sector
    {
        public string Name { get; set; }

        public ArrayList Shelves { get; set; }
        public Sector(string name)
        {
            this.Name = name;
            this.Shelves = new ArrayList();
        }

        public void SectorBook(Shelve shelve)
        {
            this.Shelves.Add(shelve);
        }
    }
}