
using System;

namespace VsCodeProOne.Patterns.NullObjectPattern
{
    public static class NullObjectPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("空对象模式测试...");
            var customer1 = CustomerFactory.GetCustomer("Rob");
            var customer2 = CustomerFactory.GetCustomer("Joe");
            var customer3 = CustomerFactory.GetCustomer("Julie");
            var customer4 = CustomerFactory.GetCustomer("DuGu");
            Console.WriteLine("Customers");
            Console.WriteLine("customer1 : " + customer1.GetName());
            Console.WriteLine("customer2 : " + customer2.GetName());
            Console.WriteLine("customer3 : " + customer3.GetName());
            Console.WriteLine("customer4 : " + customer4.GetName());
            Console.WriteLine("");
        }
    }

}
