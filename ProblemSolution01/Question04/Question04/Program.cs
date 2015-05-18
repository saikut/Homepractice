using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question04
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            int sumOfSquare = 0;
            int squareOfSum = 0;
            int total = 0;

            for (int i = min; i <= max; i++)
            {
                sumOfSquare += (i*i);
            }
            for (int  i = min;  i <= max;  i++)
            {
                total += i;
            }
            squareOfSum = total*total;

            Console.WriteLine("Difference between the squareOfSum and the sumOfSquare = {0}", squareOfSum - sumOfSquare);
            Console.ReadLine();
        }
    }
}
