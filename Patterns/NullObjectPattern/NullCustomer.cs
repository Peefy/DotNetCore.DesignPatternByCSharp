namespace VsCodeProOne.Patterns.NullObjectPattern
{
    public class NullCustomer : AbstractCustomer
    {
        public NullCustomer()
        {
        }

        public override string GetName()
        {
            return "Not Available in Customer Database";
        }

        public override bool IsNil()
        {
            return true;
        }
    }

}
