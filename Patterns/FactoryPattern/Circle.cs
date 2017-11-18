
using System;

namespace VsCodeProOne.Patterns.FactoryPattern
{
    public class Circle : IShape
    {
        public Circle()
        {
            Console.WriteLine($"{nameof(Circle) } construtor");
        }

        public virtual void Draw()
        {
            Console.WriteLine($"{nameof(Circle) } call draw");
        }
    }

}

