using Opgave4.Interfaces;
using System;
using System.Collections.Generic;

namespace Opgave4
{
    public class ZonnePaneelSysteem : IObservable
    {
        public int Wattage { get; set; }
        private List<IObserver> observers;
        private Random random;
        public ZonnePaneelSysteem()
        {
            observers = new List<IObserver>();
            random = new Random();
        }

        public void NieuweMeeting()
        {
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
