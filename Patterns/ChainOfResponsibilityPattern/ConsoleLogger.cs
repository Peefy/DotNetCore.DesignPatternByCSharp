
using System;

namespace VsCodeProOne.Patterns.ChainOfResponsibilityPattern
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this._level = level;
        }

        public override void Write(string message)
        {
            Console.WriteLine("Stadard Console::Logger: " + message);
        }
    }

}

