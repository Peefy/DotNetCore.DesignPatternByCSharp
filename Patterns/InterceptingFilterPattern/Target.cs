
using System;

namespace VsCodeProOne.Patterns.InterceptingFilterPattern
{
    public class Target : IFilter
    {
        public void Excute(string request)
        {
            Console.WriteLine("Executing request: " + request);
        }
    }

}
