namespace VsCodeProOne.Patterns.CompositeEntityPattern
{
    public class CompositeEntity
    {
        CoarseGrainedObject cgo = new CoarseGrainedObject();

        public void SetData(string data1, string data2) => cgo.SetData(data1, data2);

        public string[] GetData() => cgo.GetData();

    }

}

