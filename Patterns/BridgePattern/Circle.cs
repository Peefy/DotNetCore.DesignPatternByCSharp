namespace VsCodeProOne.Patterns.BridgePattern
{
    public class Circle : Shape
    {
        private int _x, _y, _radius;
        public Circle(int x, int y, int radius, IDrawApi drawApi) : base(drawApi)
        {
            this._x = x;
            this._y = y;
            this._radius = radius;
        }

        public override void Draw()
        {
            this._drawApi.DrawCircle(_radius, _x, _y);
        }
    }

}
