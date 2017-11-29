namespace VsCodeProOne.Patterns.VisitorPattern
{
    public class Computer : IComputerPart
    {

        IComputerPart[] _parts = 
        {
            new Mouse(), 
            new Keyboard(), 
            new Monitor()
        };

        public Computer()
        {
           
        }

        public void Accept(IComputerVisitor computerVisitor)
        {
            foreach(var part in _parts)
            {
                part.Accept(computerVisitor);
            }
            computerVisitor.Visit(this);
        }
    }

}
