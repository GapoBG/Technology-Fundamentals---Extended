using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CountNegativeElem
{
    class countNegative
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int[] array = new int[inputNum];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
