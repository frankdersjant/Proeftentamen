using Opgave2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    public class Album : IVinylAlbum
    {
        public string Title { get; private set; }
        public string Band { get; private set; }
        public int Year { get; private set; }
        public Album(string title, string band, int year)
        {
            this.Title = title;
            this.Band = band;
            this.Year = year;
        }
        public void Play()
        {
            Console.WriteLine("playing album '{0}'", ToString());
        }
        public void Stop()
        {
            Console.WriteLine("stopped album '{0}'", ToString());
        }
        public void Pause()
        {
            Console.WriteLine("paused album '{0}'", ToString());
        }
        public override string ToString()
        {
            return String.Format("{0}, {1} ({2})", Title, Band, Year);
        }
    }
}
