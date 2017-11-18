
using System;

namespace VsCodeProOne.Patterns.FlyWeightPattern
{
    public static class FlyWeightPatternDemo
    {

        static string[] colors = { "red", "green", "blue", "white" };

        static string RandomColor => colors[(int)(new Random().Next() * colors.Length)];

        static int RandomX => (int)(new Random().Next() * 100);
        static int RandomY => (int)(new Random().Next() * 100);

        public static void Test()
        {
            for (var i = 0; i < 20; ++i)
            {
                var circle = ShapeFactory.GetCircle(RandomColor) as RadiusCircle;
                circle.SetX(RandomX);
                circle.SetY(RandomY);
                circle.SetRadius(100);
                circle.Draw();
            }
        }
    }

}

