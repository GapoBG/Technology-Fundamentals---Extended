using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class transport
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double result = Math.Ceiling(input / 24);
            Console.WriteLine(result);
        }
    }
}
