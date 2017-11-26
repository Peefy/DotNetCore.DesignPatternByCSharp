namespace VsCodeProOne.Patterns.StatePattern
{
    public class Context
    {
        private IBaseState _state;

        public Context()
        {
            _state = null;
        }

        public void SetState(IBaseState state)
        {
            _state = state;
        }

        public IBaseState GetState()
        {
            return _state;
        }

    }

}
