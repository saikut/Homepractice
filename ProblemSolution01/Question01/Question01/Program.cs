using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter Upper Number :");
            int upperNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter lower Number :");

            int lowerNumber = Convert.ToInt32(Console.ReadLine());


            for (int i = lowerNumber; i <= upperNumber; i++)
            {
                Console.WriteLine(i);
               
           
            }
          
             
            Console.ReadLine();

            


        }
    }
}
