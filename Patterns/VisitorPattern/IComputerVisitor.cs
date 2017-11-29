namespace VsCodeProOne.Patterns.VisitorPattern
{
    public interface IComputerVisitor
    {
        void Visit(Computer computer);
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }

}
