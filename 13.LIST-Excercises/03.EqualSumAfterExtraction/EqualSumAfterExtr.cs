using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSumAfterExtraction
{
    class EqualSumAfterExtr
    {
        static void Main(string[] args)
        {
            List<int> numList1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> numList2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sum1 = 0;
            int sum2 = 0;

            foreach (var item in numList1)
            {
                numList2.Remove(item);
            }
            sum1 = numList1.Sum();
            sum2 = numList2.Sum();

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes. Sum: {0}", sum1);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sum1-sum2));
            }
        }
    }
}
