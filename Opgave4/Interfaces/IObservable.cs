﻿namespace Opgave4.Interfaces
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NieuweMeeting();
    }
}
