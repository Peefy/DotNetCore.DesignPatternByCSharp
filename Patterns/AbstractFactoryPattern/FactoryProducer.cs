namespace VsCodeProOne.Patterns.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            switch(choice)
            {
                case "Color" : return new ColorFactory();
                case "Shape" : return new ShapeFactory();
                default : return null;
            }
        }

        public static void Test()
        {
            var producer = GetFactory("Color");
            producer.GetColor(nameof(Red)).Fill();
            producer.GetColor(nameof(Green)).Fill();
            producer.GetColor(nameof(Blue)).Fill();
        }

    }

}