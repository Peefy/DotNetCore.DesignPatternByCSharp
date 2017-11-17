
using System;

using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.PrototypePattern
{
    public static class PrototypeDemo
    {
        public static void Test()
        {
            Console.WriteLine("原型模式测试");
            ShapeCache.LoadCache();
            Console.WriteLine("Shape: " + 
                ShapeCache.GetShape(nameof(Circle)).GetType());
            Console.WriteLine("Shape: " + 
                ShapeCache.GetShape(nameof(Rectangle)).GetType());
            Console.WriteLine("Shape: " + 
                ShapeCache.GetShape(nameof(Square)).GetType());
            Console.WriteLine("");
        }
    }

}
