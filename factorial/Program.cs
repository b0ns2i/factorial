using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int factorial = 1;

            while (true)
            {
                Console.WriteLine("Введите N:");
                number = Convert.ToInt32(Console.ReadLine());

                while (number > 1)
                {
                    factorial *= number ;
                    number--;
                }

                Console.WriteLine("N! = " + factorial);
                Console.WriteLine();

                factorial = 1;
               
            } 
          

         
        }
    }
}
