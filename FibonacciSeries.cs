using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programing
{
    public static class FibonacciSeries
    {
        public static void Fibonacci_Series()
        {
            int Num, n1 = 0, n2 = 1, n3, i;

            Console.WriteLine("Enter the Num of elements");
            Num = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " ");

            for(i=2; i<Num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
