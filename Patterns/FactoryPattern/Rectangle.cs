
using System;

namespace VsCodeProOne.Patterns.FactoryPattern
{
    public class Rectangle : IShape
    {
        public Rectangle()
        {
            Console.WriteLine($"{nameof(Rectangle) } construtor");
        }

        public virtual void Draw()
        {
            Console.WriteLine($"{nameof(Rectangle) } call draw");
        }
    }

}

