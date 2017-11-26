using System.Collections.Generic;

namespace VsCodeProOne.Patterns.ObserverPattern
{
    public class Subject
    {
        List<Observer> _observers = new List<Observer>();

        private int _state;
        public int State 
        {
            get => _state;
            set 
            {
                this._state = value;
                NotifyAllObservers();
            }
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach(var observer in _observers)
            {
                observer.Update();
            }
        }

    }

}
