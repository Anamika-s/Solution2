using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class NamedParameter
    {
        static void Main()
        {
            DisplayDetails(1, "ajay", "b001", 90, "deepak kumar");
            DisplayDetails(90, "teacher1", "b002", 9, "myname");
            DisplayDetails(score: 90, teacherName: "teacherName", batch: "b001",
              rn: 10, name: "studentname");
        }

        static void DisplayDetails(int rn, string name, string batch, int score,
            string teacherName)
        {
            Console.WriteLine("Rn is "+ rn);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Teacher Name " + teacherName);
            Console.WriteLine("Batch is " + batch);
            Console.WriteLine("Score is " + score);
        }
    }
}
