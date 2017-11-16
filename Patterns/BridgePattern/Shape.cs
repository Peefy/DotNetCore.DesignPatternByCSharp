namespace VsCodeProOne.Patterns.BridgePattern
{
    public abstract class Shape
    {
        protected IDrawApi _drawApi;
        protected Shape(IDrawApi drawApi)
        {
            this._drawApi = drawApi;
        }
        public abstract void Draw();
    }

}
