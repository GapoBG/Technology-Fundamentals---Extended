using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            double inputA = int.Parse(Console.ReadLine());
            double inputB = int.Parse(Console.ReadLine());

            double result = Math.Round(((inputA * inputB) / 1000000),1);
            
            Console.WriteLine($"{inputA}x{inputB} => {result}MP");
        }
    }
}
