
using System;

namespace VsCodeProOne.Patterns.AbstractFactoryPattern
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside::blue::fill() method");
        }
    }

}