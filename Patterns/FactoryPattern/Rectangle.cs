
using System;

namespace VsCodeProOne.Patterns.FactoryPattern
{
    internal class Rectangle : IShape
    {
        public Rectangle()
        {
            Console.WriteLine($"{nameof(Rectangle) } construtor");
        }

        public void Draw()
        {
            Console.WriteLine($"{nameof(Rectangle) } call draw");
        }
    }

}

