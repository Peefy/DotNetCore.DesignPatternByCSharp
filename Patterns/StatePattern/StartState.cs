
using System;

namespace VsCodeProOne.Patterns.StatePattern
{
    public class StartState : IBaseState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.SetState(this);
        }

        public override string ToString()
        {
            return nameof(StartState);
        }

    }

}
