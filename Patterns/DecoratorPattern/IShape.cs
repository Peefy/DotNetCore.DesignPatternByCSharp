
using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.DecoratorPattern
{
    public abstract class ShapeDecorator : IShape
    {

        protected IShape _decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            this._decoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            _decoratedShape.Draw();

        }

    }

}
