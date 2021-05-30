using Opgave4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class PaneelController : IPaneelController
    {
        private IObservable Zonnepaneel;
        public PaneelController(IObservable zonnepaneel)
        {
            this.Zonnepaneel = zonnepaneel;
        }
        public void NieuweMeeting()
        {
            Zonnepaneel.NieuweMeeting();
        }
    }
}
