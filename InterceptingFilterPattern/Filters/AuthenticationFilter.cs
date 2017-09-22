using InterceptingFilterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern.Filters
{
    public class AuthenticationFilter : IFilter
    {
        public void Execute(string request)
        {
            Console.WriteLine(String.Format("Authenticating request : {0}", request));
        }
    }
}
