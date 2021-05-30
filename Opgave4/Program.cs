using Opgave4.Interfaces;
using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            // create solarpanel system -> model

            IObservable systeem = new ZonnepaneelSysteem();
            
            
            IPaneelController controller = new PaneelController(systeem);
            
            // create a solarpanel display -> view
            IObserver display = new Zonnedisplay(systeem);
            
            // perform a few measurements
            for (int i = 0; i < 10; i++)
                controller.NieuweMeeting();
            Console.ReadKey();
            
        }
    }
}
