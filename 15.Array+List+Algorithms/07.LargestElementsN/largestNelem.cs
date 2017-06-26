using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestElementsN
{
    class largestNelem
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int countElement = int.Parse(Console.ReadLine());

            numList.Sort();
            numList.Reverse();

            for (int i = 0; i < countElement; i++)
            {
                Console.Write("{0} ", numList[i]);
            }
            Console.WriteLine();
        }
    }
}
