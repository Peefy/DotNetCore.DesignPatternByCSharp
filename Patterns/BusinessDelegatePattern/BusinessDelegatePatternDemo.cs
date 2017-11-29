
using System;

namespace VsCodeProOne.Patterns.BusinessDelegatePattern
{
    public static class BusinessDelegatePatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("业务代表模式测试...");
            var businessDelegate = new BusinessDelegate();
            businessDelegate.ServiceType = "EJB";
            var client = new Client(businessDelegate);
            client.DoTask();
            businessDelegate.ServiceType = "JMS";
            client.DoTask();
            Console.WriteLine("业务代表模式测试结束");
        }
    }

}
