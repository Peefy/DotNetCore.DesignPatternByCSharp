
using System;

namespace VsCodeProOne.Patterns.ChainOfResponsibilityPattern
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this._level = level;
        }

        public override void Write(string message)
        {
            Console.WriteLine("Error Console::Logger: " + message);
        }
    }

}

