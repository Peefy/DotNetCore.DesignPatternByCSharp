using System.Collections.Generic;

namespace VsCodeProOne.Patterns.InterceptingFilterPattern
{
    public class FilterChain
    {
        List<IFilter> filters = new List<IFilter>();
        Target target;

        public void AddFilter(IFilter filter)
        {
            filters.Add(filter);
        }

        public void Excute(string request)
        {
            foreach(var filter in filters)
            {
                filter.Excute(request);
            }
            target?.Excute(request);
        }

        public void SetTarget(Target target)
        {
            this.target = target;
        }

    }

}
