
using System;

namespace VsCodeProOne.Patterns.FactoryPattern
{
    internal class Square : IShape
    {
        public Square()
        {
            Console.WriteLine($"{nameof(Square) } construtor");
        }

        public void Draw()
        {
            Console.WriteLine($"{nameof(Square) } call draw");
        }
    }

}

