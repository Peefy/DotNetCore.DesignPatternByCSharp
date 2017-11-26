
using System;

namespace VsCodeProOne.Patterns.ObserverPattern
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this._subject = subject;
            this._subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + 
                _subject.State.ToString("B4"));
        }
    }

}
