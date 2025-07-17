namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 90;
            num1 = 91;
            Byte.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine(num1);
            byte[] num = new byte[10];
            Console.WriteLine("enter numbers");
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = Byte.Parse(Console.ReadLine());
            //}


            for (int i = 0; i < num.Length; i++)
            {
                Byte.TryParse(Console.ReadLine(), out num[i]);
            }
            Console.WriteLine("numbers are ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            // Array dec & initilization

            int[] num2 = new int[] { 11, 23, 3, 40 };
            Console.WriteLine("numbers are ");
            for (int i = 0; i < num2.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            // after C# 7.0
            int[] num3 = [10, 12, 13, 15, 18];
            int sum = 0;
            for(int i = 0;i<num3.Length;i++)
            {
                sum += num3[i];
            }

            Console.WriteLine( "sum is " + sum);
            float avg = (float)sum / num3.Length;
            Console.WriteLine("average is " + avg);
            int[,] matrixA = new int[3, 3];
            Console.WriteLine("enter values ");
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    matrixA[i,j] =byte.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("matrix a ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("");
                for ( int j=0; j<3;j++)
                {
                    Console.Write(matrixA[i,j] + "\t");
                }
            }

            Console.WriteLine("jagged array");
            int[][] marks = new int[10][];
            Console.WriteLine("enter marks of student 1");
            marks[0] = new int[3];
            for(int i=0; i<3;i++)
            {
                marks[0][i] = Byte.Parse(Console.ReadLine());
            }
            Console.WriteLine("marks of student 1");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(marks[0][i]);
            }

            Console.WriteLine("enter marks of student 2");
            marks[1] = new int[4];
            for (int i = 0; i < 4; i++)
            {
                marks[1][i] = Byte.Parse(Console.ReadLine());
            }
            Console.WriteLine("marks of student 2");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(marks[1][i]);
            }




















        }
        }
}
