using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class ParamsArray
    {
        static void Main()
        {
            Console.WriteLine(Add(1,2));
            Console.WriteLine(Add(1,2,3,4,5,6,7,8,9,10));
            Console.WriteLine(Add(1));
        }

        static int Add(params int[]num)
        {
            int sum = 0;
            foreach (int i in num)
            {
                sum += i;
            }
            return sum;
        }
    }
}
