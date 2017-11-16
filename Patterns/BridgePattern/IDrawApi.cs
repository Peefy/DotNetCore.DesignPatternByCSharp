namespace VsCodeProOne.Patterns.BridgePattern
{
    public interface IDrawApi
    {
        void DrawCircle(int radius, int x,int y);
    }

    public static class BridgePatternDemo
    {
        public static void Test()
        {
            var redCircle = new Circle(100,101,10,new RedCircle());
            var greenCircle = new Circle(100,101,10,new GreenCircle());
            redCircle.Draw();
            greenCircle.Draw();
        }
    }

}
