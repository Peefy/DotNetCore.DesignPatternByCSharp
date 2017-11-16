
using System;

using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.AbstractFactoryPattern
{
    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside::red::fill() method");
        }
    }

    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside::green::fill() method");
        }
    }

    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside::blue::fill() method");
        }
    }

    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shape);
        public abstract IColor GetColor(string color);
    }

    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            switch(choice)
            {
                case "Color" : return new ColorFactory();
                case "Shape" : return new ShapeFactory();
                default : return null;
            }
        }

        public static void Test()
        {
            var producer = GetFactory("Color");
            producer.GetColor(nameof(Red)).Fill();
            producer.GetColor(nameof(Green)).Fill();
            producer.GetColor(nameof(Blue)).Fill();
        }

    }

}