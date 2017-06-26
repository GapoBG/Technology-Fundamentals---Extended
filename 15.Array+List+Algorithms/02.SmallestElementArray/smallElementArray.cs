using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallestElementArray
{
    class smallElementArray
    {
        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            smallElementFound(numberArray);
            Console.WriteLine(smallElementFound(numberArray));
        }

        private static int smallElementFound(int[] numArray)
        {
            int smallestElement = int.MaxValue;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < smallestElement)
                {
                    smallestElement = numArray[i];
                }
            }
            return smallestElement;
        }
    }
}
