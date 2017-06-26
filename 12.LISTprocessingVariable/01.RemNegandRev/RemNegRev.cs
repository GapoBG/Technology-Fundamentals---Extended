using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemNegandRev
{
    class RemNegRev
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> newIntList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    newIntList.Add(numbers[i]);
                }
            }

            if (newIntList.Any())
            {
                newIntList.Reverse();
                Console.WriteLine(string.Join(" ", newIntList));
            }

            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
