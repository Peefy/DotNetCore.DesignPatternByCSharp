namespace VsCodeProOne.Patterns.NullObjectPattern
{
    public class CustomerFactory
    {
        public static string[] Names = {"Rob", "Joe", "Julie"};

        public static AbstractCustomer GetCustomer(string name)
        {
            for(var i = 0;i < Names.Length;i++)
            {
                if(name == Names[i])
                    return new RealCustomer(name);
            }
            return new NullCustomer();
        }
    }

}
