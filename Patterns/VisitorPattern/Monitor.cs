namespace VsCodeProOne.Patterns.VisitorPattern
{
    public class Monitor : IComputerPart
    {
        public void Accept(IComputerVisitor computerVisitor)
        {
            computerVisitor.Visit(this);
        }
    }

}
