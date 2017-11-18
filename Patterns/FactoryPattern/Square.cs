
using System;

namespace VsCodeProOne.Patterns.FactoryPattern
{
    public class Square : IShape
    {
        public Square()
        {
            Console.WriteLine($"{nameof(Square) } construtor");
        }

        public virtual void Draw()
        {
            Console.WriteLine($"{nameof(Square) } call draw");
        }
    }

}

