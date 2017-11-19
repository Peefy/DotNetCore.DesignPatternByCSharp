
using System;

namespace VsCodeProOne.Patterns.ProxyPattern
{
    public static class ProxyPatternDemo 
    {
        public static void Test()
        {
            var image = new ProxyImage("temp.jpg");
            image.Display();
            Console.WriteLine("");
            image.Display();
        }
    }

}
