namespace VsCodeProOne.Patterns.StrategyPattern
{
    public class Context
    {
        IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public int ExcuteStrategy(int num1, int num2)
        {
            return this._strategy.DoOperation(num1, num2);
        }

    }

}
