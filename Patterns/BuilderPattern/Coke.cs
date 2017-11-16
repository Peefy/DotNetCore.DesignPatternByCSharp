namespace VsCodeProOne.Patterns.BuilderPattern
{
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return nameof(Coke);
        }

        public override float Price()
        {
            return 23.2f;
        }
    }


}
