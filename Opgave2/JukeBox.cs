using Opgave2.Interfaces;
using System.Collections.Generic;

namespace Opgave2
{
    public class JukeBox
    {
        public List<IVinylSingle> Singles;
        public JukeBox(List<IVinylSingle> singles)
        {
            Singles = singles;
        }
        public void Play()
        { }

        public void SelectSingle(int indexsingles)
        { }
    }
}
