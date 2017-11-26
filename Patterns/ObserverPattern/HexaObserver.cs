
using System;

namespace VsCodeProOne.Patterns.ObserverPattern
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this._subject = subject;
            this._subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + 
                _subject.State.ToString("X2"));
        }
    }

}
