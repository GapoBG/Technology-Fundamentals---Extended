using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountRealNum
{
    class CountRealNum
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> counts = new Dictionary<double, int>();
            Array.Sort(numbers);

            foreach (var num in numbers)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }
        }
    }
}
