namespace VsCodeProOne.Patterns.ChainOfResponsibilityPattern
{
    public abstract class AbstractLogger
    {
        public const int Info = 1;
        public const int Debug = 2;

        public const int Error = 3;

        protected int _level;

        protected AbstractLogger _nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            _nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if(_level <= level)
            {
                Write(message);
            }
            if(_nextLogger != null)
            {
                _nextLogger.LogMessage(level, message);
            }
        }

        public abstract void Write(string message);

    }

}

