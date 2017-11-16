
using System;

using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public ShapeFactory()
        {
        }

        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shape)
        {
            return null;
        }
    }

}