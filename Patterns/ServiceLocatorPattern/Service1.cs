
using System;

namespace VsCodeProOne.Patterns.ServiceLocatorPattern
{
    public class Service1 : IService
    {
       
        public void Execute()
        {
            Console.WriteLine($"Executing {nameof(Service1)}");
        }

        public string GetName()
        {
            return nameof(Service1);
        }
    }

}
