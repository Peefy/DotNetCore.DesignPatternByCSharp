
using System;

namespace VsCodeProOne.Patterns.BridgePattern
{
    public class RedCircle : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: " + 
                + radius +", x: " + x +", "+ y + "]");
        }
    }

}
