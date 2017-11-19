
using System;

namespace VsCodeProOne.Patterns.ProxyPattern
{
    public static class ProxyPatternDemo 
    {
        public static void Test()
        {
            Console.WriteLine("代理模式测试...");
            var image = new ProxyImage("temp.jpg");
            image.Display();
            Console.WriteLine("");
            image.Display();
            Console.WriteLine("");
        }
    }

}
