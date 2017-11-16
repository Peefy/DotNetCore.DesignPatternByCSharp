

using System;

namespace VsCodeProOne.Patterns.SingletonPattern
{
    public class ServiceLocator
    {
        static  ServiceLocator _instance;

        public static ServiceLocator Instance => 
            _instance ?? (_instance = new Lazy<ServiceLocator>(() => new ServiceLocator()).Value);

        public void ShowMessage()
        {
            Console.WriteLine("ServiceLocator test");
        }

    }

}
