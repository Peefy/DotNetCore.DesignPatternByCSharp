
using System;

namespace VsCodeProOne.Patterns.StatePattern
{
    public static class StatePatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("状态模式测试...");
            var context = new Context();
            var startState = new StartState();
            startState.DoAction(context);
            Console.WriteLine(context.GetState().ToString());
            var stopState = new StopState();
            stopState.DoAction(context);
            Console.WriteLine(context.GetState().ToString());
            Console.WriteLine("");
        }
    }

}
