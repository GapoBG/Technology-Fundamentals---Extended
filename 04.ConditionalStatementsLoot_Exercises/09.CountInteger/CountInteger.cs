using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountInteger
{
    class CountInteger
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var number = 0;
            var count = 0;

            while (int.TryParse(inputLine, out number))
            {
                inputLine = Console.ReadLine();
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
