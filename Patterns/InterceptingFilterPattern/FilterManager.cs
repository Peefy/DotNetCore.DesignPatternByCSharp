namespace VsCodeProOne.Patterns.InterceptingFilterPattern
{
    public class FilterManager
    {
        FilterChain filterChain;

        public FilterManager(Target target)
        {
            filterChain = new FilterChain();
            filterChain.SetTarget(target);
        }

        public void SetFilter(IFilter filter)
        {
            filterChain.AddFilter(filter);
        }

        public void filterRequest(string request)
        {
            filterChain.Excute(request);
        }

    }

}
