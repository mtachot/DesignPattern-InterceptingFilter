using InterceptingFilterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern.Filters
{
    public class DebugFilter : IFilter
    {
        public void Execute(string request)
        {
            Console.WriteLine(String.Format("request log : {0}", request));
        }
    }
}
