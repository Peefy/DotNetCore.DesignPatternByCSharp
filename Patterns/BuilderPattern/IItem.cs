namespace VsCodeProOne.Patterns.BuilderPattern
{
    public interface IItem
    {
        string Name();
        IPacking Packing();
        float Price();
    }


}
