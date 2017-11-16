namespace VsCodeProOne.Patterns.BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name();
        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();

    }


}
