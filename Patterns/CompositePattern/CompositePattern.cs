
using System;

namespace VsCodeProOne.Patterns.CompositePattern
{
    public static class CompositePattern
    {
        public static void Test()
        {
            Console.WriteLine("组合模式测试");
            var CEO = new Employee("DuGu","CEO",30000);
            var headSales = new Employee("Robert","Head Sales", 20000);
            var headMarket = new Employee("John", "Head Sales", 20000);
            var clerk1 = new Employee("Laura", "Marketing", 10000);
            var clerk2 = new Employee("Bob", "Marketing", 10000);
            var salesExecutive1 = new Employee("Richard", "Sales", 10000);
            var salesExecutive2 = new Employee("Rob", "Sales", 10000);
            CEO.Add(headSales);
            CEO.Add(headMarket);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarket.Add(clerk1);
            headMarket.Add(clerk2);

            headMarket.Add(clerk1);
            headMarket.Add(clerk2);

            Console.WriteLine(CEO);

            foreach(var headEmployee in CEO.Subordinates)
            {
                Console.WriteLine(headEmployee);
                foreach(var employee in headEmployee.Subordinates)
                {
                    Console.WriteLine(employee);
                }
            }
            Console.WriteLine("");
        }
    }

}
