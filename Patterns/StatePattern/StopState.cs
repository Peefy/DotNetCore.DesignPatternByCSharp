
using System;

namespace VsCodeProOne.Patterns.StatePattern
{
    public class StopState : IBaseState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.SetState(this);    
        }

        public override string ToString()
        {
            return nameof(StopState);
        }

    }

}
