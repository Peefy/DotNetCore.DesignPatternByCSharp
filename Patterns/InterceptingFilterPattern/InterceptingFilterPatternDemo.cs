namespace VsCodeProOne.Patterns.InterceptingFilterPattern
{
    public class InterceptingFilterPatternDemo
    {
        public static void Run()
        {
            var filterManager = new FilterManager(new Target());
            filterManager.SetFilter(new AuthenticationFilter());
            filterManager.SetFilter(new DebugFilter());
            var client = new Client();
            client.SetFilterManager(filterManager);
            client.SendRequest("Home");
        }
    }

}
