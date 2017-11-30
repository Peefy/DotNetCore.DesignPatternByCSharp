
using System;

namespace VsCodeProOne.Patterns.ServiceLocatorPattern
{
    public class Service2 : IService
    {
       
        public void Execute()
        {
            Console.WriteLine($"Executing {nameof(Service2)}");
        }

        public string GetName()
        {
            return nameof(Service2);
        }
    }

}
