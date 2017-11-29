
using System;

namespace VsCodeProOne.Patterns.BusinessDelegatePattern
{
    public class EJBService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("processing task by invoking EJB Service");
        }
    }

}
