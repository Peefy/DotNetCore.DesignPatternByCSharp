using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        public ColorFactory()
        {
        }

        public override IColor GetColor(string color)
        {
            switch(color)
            {
                case nameof(Red) : return new Red();
                case nameof(Green) : return new Green();
                case nameof(Blue) : return new Blue();
                default : return null;
            }
        }

        public override IShape GetShape(string IShape)
        {
            return null;
        }
    }
}