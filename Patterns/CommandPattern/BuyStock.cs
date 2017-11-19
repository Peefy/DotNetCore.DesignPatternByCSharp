namespace VsCodeProOne.Patterns.CommandPattern
{
    public class BuyStock : IOrder
    {
        private Stock _abcStock;

        public BuyStock(Stock abcStock)
        {
            this._abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Buy();
        }
    }

}
