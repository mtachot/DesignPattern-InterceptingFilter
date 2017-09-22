using InterceptingFilterPattern.Classes;
using InterceptingFilterPattern.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            FilterManager filterManager = new FilterManager(new Target());
            filterManager.SetFilter(new AuthenticationFilter());
            filterManager.SetFilter(new DebugFilter());

            Client client = new Client();
            client.SetFilterManager(filterManager); client.SendRequest("HOME");

            Console.ReadLine();
        }
    }
}
