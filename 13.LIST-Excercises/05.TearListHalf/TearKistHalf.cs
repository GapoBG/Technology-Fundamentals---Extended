using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListHalf
{
    class TearKistHalf
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int br1 = 0;
            int br2 = 0;

            for (int i = 0; i < numList.Count; i++)
            {
                br1++;
            }

            int[] numArray = new int[br1 + br1/2];
            
            for (int i = 1; i < numArray.Length; i+=3)
            {
                numArray[i] = numList[br2];
                br2++;
            }
            for (int i = 0; i < numArray.Length; i+=3)
            {
                numArray[i] = numList[br2] / 10;
                numArray[i+2] = numList[br2] % 10;
                br2++;
            }
            Console.WriteLine(string.Join(" ",numArray));
        }
    }
}
