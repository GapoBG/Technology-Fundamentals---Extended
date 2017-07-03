using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int foundNum = int.Parse(Console.ReadLine());

            int countLinerSearch = LinearSearchNum(numList, foundNum);
            int countBinnerSearch = BinnerSearchNum(numList, foundNum);
            numList.Sort();
            if (numList.Contains(foundNum))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine($"Linear search made {countLinerSearch} iterations");
            Console.WriteLine($"Binary search made {countBinnerSearch} iterations");
         }

        private static int BinnerSearchNum(List<int> numList, int foundNum)
        {
            numList.Sort();

            int min = 0;
            int max = numList.Count-1;
            int count = 0;

            while (min <= max)
            {
                int midPiont = (min + max) / 2;
                count++;

                if (numList[midPiont] < foundNum)
                {
                    min = midPiont + 1;
                }
                if (numList[midPiont] > foundNum)
                {
                    max = midPiont - 1;
                }
                if (numList[midPiont] == foundNum)
                {
                    break;
                }
            }
            return count;
        }

        private static int LinearSearchNum(List<int> numList, int foundNum)
        {
            int LinterIteration = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                LinterIteration++;
                if (foundNum == numList[i])
                {
                    return LinterIteration;
                }
            }
            return LinterIteration;
        }
    }
}
