namespace VsCodeProOne.Patterns.NullObjectPattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this._name = name;
        }

        public override string GetName()
        {
           return _name;
        }

        public override bool IsNil()
        {
            return false;
        }
    }

}
