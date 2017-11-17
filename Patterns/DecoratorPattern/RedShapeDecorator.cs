
using System;

using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        { }

        public override void Draw()
        {
            base.Draw();
            this.SetRedBorder(_decoratedShape);
        }

        public void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }

    }

}
