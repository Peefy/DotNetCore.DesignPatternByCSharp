namespace VsCodeProOne.Patterns.BuilderPattern
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return nameof(ChickenBurger);
        }

        public override float Price()
        {
            return 50.5f;
        }
    }


}
