
using System;
using System.Collections.Generic;

using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.FlyWeightPattern
{
    public class ShapeFactory
    {
        static Dictionary<string, IShape> _circleMap =
            new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            if (_circleMap.TryGetValue(color, out var shape) == true)
            {
                return shape;
            }
            var circle = new RadiusCircle(color);
            _circleMap.Add(color, circle);
            Console.WriteLine("Creating circle of color : " + color);
            return circle;
        }

    }

}

