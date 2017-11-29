namespace VsCodeProOne.Patterns.VisitorPattern
{
    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerVisitor computerVisitor)
        {
            computerVisitor.Visit(this);
        }
    }

}
