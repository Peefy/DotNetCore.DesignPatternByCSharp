namespace VsCodeProOne.Patterns.ObserverPattern
{
    public abstract class Observer
    {
        protected Subject _subject;
        public abstract void Update(); 
    }

}
