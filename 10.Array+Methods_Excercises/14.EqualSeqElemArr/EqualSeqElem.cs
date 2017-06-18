using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.EqualSeqElemArr
{
    class EqualSeqElem
    {
        static void Main(string[] args)
        {
            int[] arrayNum = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool isEqualElem = true;

            for (int i = 1; i < arrayNum.Length-1; i++)
            {
                if (arrayNum[i] != arrayNum[i - 1])
                {
                    isEqualElem = false;
                }

            }
            if (isEqualElem)
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
