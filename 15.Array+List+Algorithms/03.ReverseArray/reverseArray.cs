using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReverseArray
{
    class reverseArray
    {
        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Array.Reverse(numberArray);

            Console.WriteLine(string.Join(" ", numberArray));
        }
    }
}
