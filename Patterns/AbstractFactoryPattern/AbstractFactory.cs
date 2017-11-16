
using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shape);
        public abstract IColor GetColor(string color);
    }

}