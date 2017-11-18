
using System;

using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.FlyWeightPattern
{
    public class RadiusCircle : Circle
    {

        string _color = "";
        int _x;
        int _y;
        int _radius;

        public RadiusCircle()
        {
        }
        public RadiusCircle(string color)
        {
            _color = color;
        }

        public void SetX(int x) => _x = x;
        public void SetY(int y) => _y = y;
        public void SetRadius(int radius) => _radius = radius;

        public override void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + _color
                + ", x : " + _x + ", y :" + _y + ", radius :" + _radius);
        }

    }

}

