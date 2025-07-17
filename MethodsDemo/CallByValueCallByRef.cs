using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class CallByValueCallByRef
    {
        static void Main()
        {
            int n1 = 10;
            Console.WriteLine("Value of n1 in Main before callig Change1 " + n1);
            Change1(n1);  // only 10 is going from here
            Console.WriteLine("Value of n1 in Main after callig Change1 " + n1);
            Change2(ref n1); // now n1 is passed // we are passing its reference
            Console.WriteLine("Value of n1 in Main after callig Change2 " + n1);

        }

        static void Change1(int n1)
        {
            n1 = 100;
            Console.WriteLine("Value of n1 in Change1 " + n1);
        }
        static void Change2(ref int n1)
        {
            n1 = 200;
            Console.WriteLine("Value of n1 in Change2 " + n1);
        }
    }
}
