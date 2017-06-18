using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountGivenElement
{
    class CountGivenElem
    {
        static void Main(string[] args)
        {
            int[] arrayNum = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int givenElem = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arrayNum.Length; i++)
            {
                if (givenElem == arrayNum[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
