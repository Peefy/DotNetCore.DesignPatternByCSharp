namespace VsCodeProOne.Patterns.BusinessDelegatePattern
{
    public class BusinessDelegate
    {
        private BusinessLookUp _lookUpService = new BusinessLookUp();
        private IBusinessService _businessService;
        public string ServiceType {private get;set;}

        public void DoTask()
        {
            _businessService = _lookUpService.GetBusinessService(ServiceType);
            _businessService.DoProcessing();
        }

    }

}
