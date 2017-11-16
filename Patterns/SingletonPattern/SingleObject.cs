

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

}
