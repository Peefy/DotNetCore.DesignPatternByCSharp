
using System;

namespace VsCodeProOne.Patterns.FactoryPattern
{
    internal class Rectangle : IShape
    {
        public Rectangle()
        {
            Console.WriteLine($"{nameof(Rectangle) } construtor");
        }

        public void Draw()
        {
            Console.WriteLine($"{nameof(Rectangle) } call draw");
        }
    }

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

    ///<summary>
    /// 形状工厂，
    /// 工厂模式适用于日志记录，
    /// 从远程或者本地获取数据
    ///</summary>
    public class ShapeFactory
    {
        public ShapeFactory()
        {
        }

        public IShape GetShape(string shapeName)
        {
            if(string.IsNullOrEmpty(shapeName) == true)
                throw new NullReferenceException(nameof(shapeName));
            switch(shapeName)
            {
                case nameof(Square) : 
                    return new Square();
                case nameof(Rectangle): 
                    return new Rectangle();
                case nameof(Circle): 
                    return new Circle();
                default: return null;
            }
        }

        public static void Test()
        {
            var factory = new ShapeFactory();
            var circle = factory.GetShape(nameof(Circle));
            circle.Draw();
            var rec = factory.GetShape(nameof(Rectangle));
            rec.Draw();
            var square = factory.GetShape(nameof(Square));
            square.Draw();
        }

    }

}

