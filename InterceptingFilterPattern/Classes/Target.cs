using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern.Classes
{
    public class Target
    {
        public void Execute(string request)
        {
            Console.WriteLine(String.Format("Executing request : {0}", request));
        }
    }
}
