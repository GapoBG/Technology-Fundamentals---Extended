using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.IncSequenceElements
{
    class IncElement
    {
        static void Main(string[] args)
        {
            int[] arrayNum = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool isIncreasing = true;

            for (int i = 1; i < arrayNum.Length; i++)
            {               
                if (arrayNum[i] < arrayNum[i-1])
                {
                    isIncreasing = false;
                    break;
                }
            }
            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
