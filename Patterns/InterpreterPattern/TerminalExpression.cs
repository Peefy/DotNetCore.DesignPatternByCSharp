namespace VsCodeProOne.Patterns.InterpreterPattern
{
    public class TerminalExpression : IExpression
    {
        string _data = "";

        public TerminalExpression(string data)
        {
            this._data = data;
        }

        public bool Interpret(string context) => context.Contains(_data);
    }

}
