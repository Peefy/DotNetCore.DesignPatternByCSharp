namespace VsCodeProOne.Patterns.MementoPattern
{
    public class Originator
    {
        public string State {get;set;}

        public Memento SaveStateToMemento() => new Memento(State);

        public void GetStateFromMemento(Memento memento)
        {
            State = memento.State;
        }

    }

}
