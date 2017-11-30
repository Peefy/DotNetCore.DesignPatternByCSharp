
using System;

namespace VsCodeProOne.Patterns.ServiceLocatorPattern
{
    public class InitialContext
    {
        public object Lookup(string jndiName)
        {
            if(string.Equals(jndiName, nameof(Service1), 
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new Service1 object");
                return new Service1();
            }
            else if(string.Equals(jndiName, nameof(Service2), 
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new Service2 object");
                return new Service2();
            }
            return null;
        }
    }

}
