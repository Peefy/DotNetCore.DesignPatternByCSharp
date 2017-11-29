namespace VsCodeProOne.Patterns.VisitorPattern
{
    public interface IComputerPart
    {
        void Accept(IComputerVisitor computerVisitor);
    }

}
