using Opgave2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    public class Single : IVinylSingle
    {
        public int Ranking { get; private set; }
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public Single(int ranking, string title, string artist)
        {
            this.Ranking = ranking;
            this.Title = title;
            this.Artist = artist;
        }
        public void Play()
        {
            Console.WriteLine("playing single '{0}'", ToString());
        }
        public void Stop()
        {
            Console.WriteLine("stopped single '{0}'", ToString());
        }
        public void Pause()
        {
            Console.WriteLine("paused single '{0}'", ToString());
        }
        public override string ToString()
        {
            return String.Format("{0}, {1} ({2})", Title, Artist, Ranking);
        }
    }
}
