
using System;

namespace VsCodeProOne.Patterns.ObserverPattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this._subject = subject;
            this._subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + 
                _subject.State.ToString("O3"));
        }
    }

}
