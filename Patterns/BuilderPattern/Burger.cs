namespace VsCodeProOne.Patterns.BuilderPattern
{
    public abstract class Burger : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }


}
