
using System;

namespace VsCodeProOne.Patterns.ObserverPattern
{
    public static class ObserverPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("观察者模式测试...");
            var subject = new Subject();
            var hex = new HexaObserver(subject);
            var oct = new OctalObserver(subject);
            var bin = new BinaryObserver(subject);

            Console.WriteLine("Fisrt State Change: 15");
            subject.State = 15;
            Console.WriteLine("Second State Change: 10");
            subject.State = 10;
            Console.WriteLine("");
        }
    }

}
