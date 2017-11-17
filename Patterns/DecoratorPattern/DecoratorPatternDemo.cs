
using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.DecoratorPattern
{
    public static class DecoratorPatternDemo
    {
        public static void Test()
        {
            var circle = new Circle();
            var redCircle = new RedShapeDecorator(circle);
            var redRectangle = new RedShapeDecorator(new Rectangle());
            circle.Draw();
            redCircle.Draw();
            redRectangle.Draw();
        }

    }

}
