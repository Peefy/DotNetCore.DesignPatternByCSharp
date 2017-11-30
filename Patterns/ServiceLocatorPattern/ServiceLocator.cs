namespace VsCodeProOne.Patterns.ServiceLocatorPattern
{
    public class ServiceLocator
    {
        private static ServiceCache cache = new ServiceCache();

        public static IService GetService(string jndiName)
        {
            var service = cache.GetService(jndiName);
            if(service != null)
                return service;
            var context = new InitialContext();
            var service1 = context.Lookup(jndiName) as IService;
            cache.AddService(service1);
            return service1;
        }

    }

}
