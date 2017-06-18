using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SmallestElementArray
{
    class SmallElement
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int minElement = int.MaxValue; 

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < minElement)
                {
                    minElement = numArray[i];              
                }
            }
            Console.WriteLine(minElement);
        }
    }
}
