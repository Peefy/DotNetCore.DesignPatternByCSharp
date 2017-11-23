namespace VsCodeProOne.Patterns.IteratorPattern
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

}
