namespace VsCodeProOne.Patterns.BusinessDelegatePattern
{
    public class Client
    {
        BusinessDelegate _businessService;

        public Client(BusinessDelegate businessService)
        {
            this._businessService = businessService;
        }

        public void DoTask()
        {
            _businessService.DoTask();
        }
    }
}
