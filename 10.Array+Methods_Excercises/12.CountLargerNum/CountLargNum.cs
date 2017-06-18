using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountLargerNum
{
    class CountLargNum
    {
        static void Main(string[] args)
        {
            double[] arrayNum = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double number = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arrayNum.Length; i++)
            {
                if (arrayNum[i] > number)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
