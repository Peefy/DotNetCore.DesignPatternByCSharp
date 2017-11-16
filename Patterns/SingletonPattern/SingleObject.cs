

using System;

namespace VsCodeProOne.Patterns.SingletonPattern
{
    public class SingleObject
    {
        private SingleObject()
        {

        }
        private static SingleObject _instance;

        public static SingleObject Instance =>
            _instance ?? (_instance = new SingleObject());

        public void ShowMessage()
        {
            Console.WriteLine("SingletonPattern test");
        }

    }

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

    public static class Singleton
    {
        public static void Test()
        {
            SingleObject.Instance.ShowMessage();
            ServiceLocator.Instance.ShowMessage();
        }
    }

}
