using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> tempList = new List<int>();

            tempList.Add(numList[0]);
            numList.Reverse();
            for (int i = 1; i < numList.Count-1; i++)
            {
                tempList.Add(numList[i]);
            }
            tempList.Add(numList[0]);
            Console.WriteLine(string.Join(" ",tempList));
        }
    }
}
