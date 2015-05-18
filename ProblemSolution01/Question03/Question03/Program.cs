using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                a = i % 3;
                b = i % 5;
                if (a == 0 || b == 0)
                {
                    Console.Write("{0}\t",i);
                    sum += i;
                }
               
            }
         Console.WriteLine("\n The Sum of all the Multiples of 3 or 5 Below 1000 : {0}",sum);
                Console.Read();
        }
    }
}
