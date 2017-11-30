namespace VsCodeProOne.Patterns.CompositeEntityPattern
{
    public class CoarseGrainedObject
    {
        DependencyObject1 do1 = new DependencyObject1();
        DependencyObject2 do2 = new DependencyObject2();

        public void SetData(string data1, string data2)
        {
            do1.Data = data1;
            do2.Data = data2;
        }

        public string[] GetData() => new string[]
            {
                do1.Data,
                do2.Data
            };

    }

}

