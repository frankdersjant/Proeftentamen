using Opgave4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class ZonnepaneelSysteem
    {
        public int Wattage { get; set; }
        private List<IObserver> observers;
        private Random random;
        public ZonnepaneelSysteem()
        {
            observers = new List<IObserver>();
            random = new Random();
        }

        public void NieuweMeeting()
        {
            // new measurement (between 300-400 Watt)
            Wattage = 300 + random.Next(100);
            NotifyObservers();
        }

       
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        private void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update(Wattage);
        }
    }
}
