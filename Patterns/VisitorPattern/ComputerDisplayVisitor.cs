
using System;

namespace VsCodeProOne.Patterns.VisitorPattern
{
    public class ComputerDisplayVisitor : IComputerVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Displaying " + nameof(Computer));
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying " + nameof(Mouse));
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying " + nameof(Keyboard));
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying " + nameof(Monitor));
        }
    }

}
