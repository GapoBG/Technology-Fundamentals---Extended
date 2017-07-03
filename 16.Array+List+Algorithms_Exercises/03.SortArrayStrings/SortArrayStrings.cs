using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayStrings
{
    class SortArrayStrings
    {
        static void Main(string[] args)
        {
            string[] inputLetter = Console.ReadLine()
                .Split(' ')
                .ToArray();

            Array.Sort(inputLetter);
            Console.WriteLine(string.Join(" ", inputLetter));
        }
    }
}
