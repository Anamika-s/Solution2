using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class WithoutMethodOverloading
    {
        static void Main()
        {
            int n1 = 90, n2 = 90;
            Console.WriteLine(Add(n1,n2));
            Console.WriteLine(Add2(n1,n2,90));
            Console.WriteLine(Add3(1,2,3,4));

        }
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static int Add2(int n1, int n2, int n3)
        {
            return (n1 + n2) + n3;
        }

        static int Add3(int a, int b, int c, int d )
        { 
            return a + b + c + d;
        }
        static float Add4(int n1, int n2, float n3)

        {
            return (n1 + n2 + n3);
        }

       
    }
}
