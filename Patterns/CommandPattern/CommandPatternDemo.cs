namespace VsCodeProOne.Patterns.CommandPattern
{
    public static class CommandPatternDemo
    {
        public static void Test()
        {
            var abcStock = new Stock();
            var buyStockOrder = new BuyStock(abcStock);
            var sellStockOrder = new SellStock(abcStock);
            var broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);
            broker.PlaceOrders();
        }
    }

}
