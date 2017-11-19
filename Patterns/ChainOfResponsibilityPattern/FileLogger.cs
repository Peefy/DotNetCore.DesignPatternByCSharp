
using System;

namespace VsCodeProOne.Patterns.ChainOfResponsibilityPattern
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this._level = level;
        }

        public override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }

}

