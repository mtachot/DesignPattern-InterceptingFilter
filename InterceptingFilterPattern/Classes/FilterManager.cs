using InterceptingFilterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern.Classes
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

        public void FilterRequest(string request)
        {
            filterChain.Execute(request);
        }
    }
}
