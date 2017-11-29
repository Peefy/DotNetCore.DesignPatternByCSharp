
using System;

namespace VsCodeProOne.Patterns.StrategyPattern
{
    public static class StrategyPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("策略模式测试...");
            var context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.ExcuteStrategy(10, 5));
            context = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 = " + context.ExcuteStrategy(10, 5));
            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = " + context.ExcuteStrategy(10, 5));
            Console.WriteLine("");
        }
    }

}
