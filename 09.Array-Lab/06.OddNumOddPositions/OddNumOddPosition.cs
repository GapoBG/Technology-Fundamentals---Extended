using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OddNumOddPositions
{
    class OddNumOddPosition
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                if (i % 2 != 0 && number[i] %2 !=0)
                {
                    Console.WriteLine($"Index {i} -> {number[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}
