using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class MethodOverloading
    {
        static void Main()
        {
            int n1 = 90, n2 = 90;
            Console.WriteLine(Add(n1,n2));
            Console.WriteLine(Add("deepak", "kumar"));
            Console.WriteLine(Add(1,2,3,4));
            Console.WriteLine(Add(1,2,90.8f));

        }
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        //static float Add(int n1, int n2)
        //{
        //    return n1 + n2;
        //}
        static int Add(int n1, int n2, int n3)
        {
            return n1 + n2+ n3;
        }

        static int Add(int n1, int n2, int n3, int n4)
        {
            return n1 + n2+ n3+ n4;
        }

        static float Add(int n1, int n2, float n3)
        {
            return n1 + n2 + n3;
        }

        static string Add(string n1, string n2)
        {
            return string.Concat(n1, " " , n2);
        }



    }
}
