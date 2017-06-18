using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayElementsEqualTheirIndex
{
    class EqualTheirIndex
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numArray.Length; i++)
            {
                if (i == numArray[i])
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine();
        }
    }
}
