
using System;

namespace VsCodeProOne.Patterns.BusinessDelegatePattern
{
    public class JMSService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("processing task by invoking JMS Service");
        }
    }

}
