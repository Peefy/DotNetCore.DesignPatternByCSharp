
using System;

namespace VsCodeProOne.Patterns.ChainOfResponsibilityPattern
{
    public static class ChainPatternDemo
    {

        private static AbstractLogger ChainOfLoggers
        {
            get
            {
                var errorLogger = new ErrorLogger(AbstractLogger.Error);
                var fileLogger = new FileLogger(AbstractLogger.Debug);
                var consoleLogger = new ConsoleLogger(AbstractLogger.Info);
                errorLogger.SetNextLogger(fileLogger);
                fileLogger.SetNextLogger(consoleLogger);
                return errorLogger;
            }
        }

        public static void Test()
        {
            Console.WriteLine("责任链模式测试...");
            var loggerChain = ChainOfLoggers;
            loggerChain.LogMessage(AbstractLogger.Info, "this is an info");
            loggerChain.LogMessage(AbstractLogger.Debug, "this is an debug info");
            loggerChain.LogMessage(AbstractLogger.Error, "this is an error info");
            Console.WriteLine("");
        }
    }

}

