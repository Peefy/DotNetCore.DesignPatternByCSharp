
using System;

namespace VsCodeProOne.Patterns.InterceptingFilterPattern
{
    public class AuthenticationFilter : IFilter
    {
        public void Excute(string request)
        {
            Console.WriteLine("Authenticating request: " + request);
        }
    }

}
