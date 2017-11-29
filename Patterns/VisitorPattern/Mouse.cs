namespace VsCodeProOne.Patterns.VisitorPattern
{
    public class Mouse : IComputerPart
    {
        public void Accept(IComputerVisitor computerVisitor)
        {
            computerVisitor.Visit(this);
        }
    }

}
