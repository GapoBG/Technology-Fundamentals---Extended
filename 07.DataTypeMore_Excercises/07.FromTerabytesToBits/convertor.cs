using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FromTerabytesToBits
{
    class convertor
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal result = num *(1024m * 1024 * 1024 * 1024 * 8);
            Console.WriteLine("{0:f0}",result);
        }
    }
}
