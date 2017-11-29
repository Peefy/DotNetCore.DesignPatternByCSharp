namespace VsCodeProOne.Patterns.BusinessDelegatePattern
{
    public class BusinessLookUp
    {
        public IBusinessService GetBusinessService(string serviceType)
        {
            if(string.IsNullOrEmpty(serviceType) == true)
                return null;
            if(serviceType == "EJB")
                return new EJBService();
            else
                return new JMSService();
        }
    }

}
