using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class StringBuilderDemo
    {
        static void Main()
        {
            string str = "a";  //imutable
            str += "bcd";
            str += "efg";
            Console.WriteLine(str);
            StringBuilder sb =new StringBuilder(); // mutable
            sb.Append("a");
            sb.Append("bcd");
            sb.Append("efg");
            Console.WriteLine(sb.ToString());
        }
    }
}
