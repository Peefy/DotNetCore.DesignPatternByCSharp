
using System;

namespace VsCodeProOne.Patterns.VisitorPattern
{
    public static class VisitorPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("访问者模式测试...");
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerDisplayVisitor());
            Console.WriteLine("");
        }
    }

}
