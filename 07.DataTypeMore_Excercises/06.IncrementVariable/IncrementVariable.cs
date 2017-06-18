using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double result = Math.Floor( num / 256);

            if (num >= 256)
            {
                Console.WriteLine(num - 256 * result);
                Console.WriteLine("Overflowed {0} times", result);
            }
            else
            {
                Console.WriteLine(num);
            }
           
            
        }
    }
}
