using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LargestElementArr
{
    class largestElementArr
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numArray = new int[num];
            int maxNum = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] > maxNum)
                {
                    maxNum = numArray[i];
                }
            }
            Console.WriteLine(maxNum);

        }
    }
}
