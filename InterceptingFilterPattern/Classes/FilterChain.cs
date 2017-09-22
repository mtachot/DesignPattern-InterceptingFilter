using InterceptingFilterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern.Classes
{
    public class FilterChain
    {
        private List<IFilter> filters = new List<IFilter>();
        private Target target;

        public void AddFilter(IFilter filter)
        {
            filters.Add(filter);
        }

        public void Execute(string request)
        {
            foreach (IFilter filter in filters)
            {
                filter.Execute(request);
            }
            target.Execute(request);
        }

        public void SetTarget(Target target)
        {
            this.target = target;
        }
    }
}
