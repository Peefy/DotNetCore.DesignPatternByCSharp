namespace VsCodeProOne.Patterns.FacadePattern
{
    public static class FacadePatternDemo
    {
        public static void Test()
        {
            var shapeMaker = new ShapeMaker();
            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }

}

