namespace VsCodeProOne.Patterns.BuilderPattern
{
    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return nameof(Pepsi);
        }

        public override float Price()
        {
            return 35.0f;
        }
    }


}
