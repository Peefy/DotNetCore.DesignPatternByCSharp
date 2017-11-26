
using System;

namespace VsCodeProOne.Patterns.MediatorPattern
{
    public static class MediatorPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("中介者模式测试...");
            InternalRun();
            Console.WriteLine("");
        }

        private static void InternalRun()
        {
            var dugu = new User("dugu");
            var john = new User("John");
            dugu.SendMessage("Hello .NET Core!");
            john.SendMessage("Hello Mono C#!");
        }
    }

}
