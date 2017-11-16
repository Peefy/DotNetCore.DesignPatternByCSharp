
using System;

namespace VsCodeProOne.Patterns.AbstractFactoryPattern
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside::green::fill() method");
        }
    }

}