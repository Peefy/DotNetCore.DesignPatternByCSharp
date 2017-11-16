
using System;

namespace VsCodeProOne.Patterns.FactoryPattern
{
    internal class Circle : IShape
    {
        public Circle()
        {
            Console.WriteLine($"{nameof(Circle) } construtor");
        }

        public void Draw()
        {
            Console.WriteLine($"{nameof(Circle) } call draw");
        }
    }

}

