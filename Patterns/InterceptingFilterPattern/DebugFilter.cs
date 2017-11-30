
using System;

namespace VsCodeProOne.Patterns.InterceptingFilterPattern
{
    public class DebugFilter : IFilter
    {
        public void Excute(string request)
        {
            Console.WriteLine("request log: " + request);
        }
    }

}
