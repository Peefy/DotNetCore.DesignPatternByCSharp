namespace VsCodeProOne.Patterns.NullObjectPattern
{
    public abstract class AbstractCustomer
    {
        protected string _name;
        public abstract bool IsNil();

        public abstract string GetName();

    }

}
