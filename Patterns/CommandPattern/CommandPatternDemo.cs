
using System;

namespace VsCodeProOne.Patterns.CommandPattern
{
    public static class CommandPatternDemo
    {
        public static void Test()
        {
            Console.WriteLine("命令模式测试...");
            var abcStock = new Stock();
            var buyStockOrder = new BuyStock(abcStock);
            var sellStockOrder = new SellStock(abcStock);
            var broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);
            broker.PlaceOrders();
            Console.WriteLine("");
            
        }
    }

}
