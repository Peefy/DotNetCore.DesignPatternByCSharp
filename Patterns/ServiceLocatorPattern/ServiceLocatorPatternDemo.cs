namespace VsCodeProOne.Patterns.ServiceLocatorPattern
{
    public static class ServiceLocatorPatternDemo
    {
        public static void Run()
        {
            var service = ServiceLocator.
                GetService(nameof(Service1));
            service.Execute();
            service = ServiceLocator.
                GetService(nameof(Service2));
            service.Execute();
            service = ServiceLocator.
                GetService(nameof(Service1));
            service.Execute();
            service = ServiceLocator.
                GetService(nameof(Service2));
            service.Execute();
        }
    }

}
