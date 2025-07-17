using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class OptionalParameters
    {
        static void Main()
        {

            SI(10000, 8, 8);
            SI(10000, 8);
        }
        static void SI( int rate, int principle = 20000, int time=10)
        {
            Console.WriteLine("SI is " + (principle * rate * time) / 100) ;
        }
    }
}
