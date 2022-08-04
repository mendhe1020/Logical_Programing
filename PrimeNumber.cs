using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programing
{
    public static class PrimeNumber
    {
        public static void Prime_Number()
        {
            Console.WriteLine("Enter the number");
            int Num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for(int i=1; i <= Num; i++)
            {
                if (Num % 1 == 0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("Num is Prime Number");
            }
            else
            {
                Console.WriteLine("Num is Not Prime Number");
            }
        }
    }
}