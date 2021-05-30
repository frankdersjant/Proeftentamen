using Opgave4.Interfaces;
using System;

namespace Opgave4
{
    public class Zonnedisplay : IObserver
    {
        private IObservable system;
        public Zonnedisplay(IObservable system)
        {
            this.system = system;
            system.AddObserver(this);
        }
        public void Update(int power)
        {
            Console.WriteLine("new measurement: {0} Watt", power);
        }
    }

}