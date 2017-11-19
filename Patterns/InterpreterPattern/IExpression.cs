
using System;

namespace VsCodeProOne.Patterns.InterpreterPattern
{
    public interface IExpression
    {
        bool Interpret(string context);
    }

    public static class InterpreterPatternDemo
    {
        static IExpression MaleExpression
        {
            get
            {
                IExpression robert = new TerminalExpression("Robert");
                IExpression john = new TerminalExpression("John");
                return new OrExpression(robert, john);
            }
        }

        static IExpression MarriedWomanExpression
        {
            get
            {
                var julie = new TerminalExpression("Julie");
                var married = new TerminalExpression("Married");
                return new AndExpression(julie, married);
            }
        }

        public static void Test()
        {
            Console.WriteLine("解释器模式测试");
            var isMale = MaleExpression;
            var isMarriedWoman = MarriedWomanExpression;
            Console.WriteLine("John is male? " + isMale.Interpret("John"));
            Console.WriteLine("Julie is married women? " 
                + isMarriedWoman.Interpret("Married Julie"));
            Console.WriteLine("");
        }

    }

}
