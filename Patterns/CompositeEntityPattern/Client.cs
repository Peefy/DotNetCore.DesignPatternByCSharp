
using System;

namespace VsCodeProOne.Patterns.CompositeEntityPattern
{
    public class Client
    {
        CompositeEntity compositeEntity = new CompositeEntity();

        public void PrintData()
        {
            for(int i = 0;i < compositeEntity.GetData().Length ; i++)
            {
                Console.WriteLine("Data: " + compositeEntity.GetData()[i]);
            }
        }

        public void SetData(string data1, string data2)
        {
            compositeEntity.SetData(data1, data2);
        }

    }

}

