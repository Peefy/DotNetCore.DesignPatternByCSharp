namespace VsCodeProOne.Patterns.IteratorPattern
{
    public class NameRepository : IContainer , IIterator
    {
        int _index;
        public string[] Names = {"Rebort", "John", "Julie", "Lora"};

        public IIterator Iterator => this;

        public bool HasNext() => _index < Names.Length;

        public object Next() => HasNext() ? Names[_index++] : null;
    }

}
