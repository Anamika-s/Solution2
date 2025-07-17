using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class OutputParemeters
    {
        // using output para, a function can return more than 1 value
        static void Main()
        {
            int sum, dif, product;
            float rem;
            Operations(20,5, out sum, out dif, out product, out rem);
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Dfference is " + dif);
            Console.WriteLine("product is " + product);
            Console.WriteLine("remainder is " + rem);

        }

        static void  Operations(int n1, int n2, 
            out int sum,
            out int difference,
            out int product,
            out float remainder)
        {
            sum = n1 + n2;
            difference = n1 - n2;
            product = n1 * n2;
            remainder = n1 % n2;
        }
    }
}
