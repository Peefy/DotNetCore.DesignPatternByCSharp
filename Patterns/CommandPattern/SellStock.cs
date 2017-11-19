namespace VsCodeProOne.Patterns.CommandPattern
{
    public class SellStock : IOrder
    {
        private Stock _abcStock;

        public SellStock(Stock abcStock)
        {
            this._abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Sell();
        }
    }

}
