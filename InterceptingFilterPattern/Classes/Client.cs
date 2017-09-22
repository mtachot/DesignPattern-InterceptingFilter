using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern.Classes
{
    public class Client
    {
        FilterManager filterManager;

        public void SetFilterManager(FilterManager filterManager)
        {
            this.filterManager = filterManager;
        }

        public void SendRequest(string request)
        {
            filterManager.FilterRequest(request);
        }
    }
}
