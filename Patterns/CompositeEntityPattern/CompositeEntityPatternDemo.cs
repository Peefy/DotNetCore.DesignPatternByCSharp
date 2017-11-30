
using System;

namespace VsCodeProOne.Patterns.CompositeEntityPattern
{
    public static class CompositeEntityPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("组合实体模式测试...");
            var client = new Client();
            client.SetData("Test", "John");
            client.PrintData();
            client.SetData("Second Test", "Data1");
            client.PrintData();
            Console.WriteLine("组合实体模式测试结束...");
        }
    }

}

