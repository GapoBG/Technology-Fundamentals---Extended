using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNum
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();
            int[] counts = new int[numberList.Max() + 1];

            foreach (var num in numberList)
            {
                counts[num]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }
        }
    }
}
