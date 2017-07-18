using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumMinMaxAverage
{
    class SumMinMaxAvg
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] number = new int[num];

            for (int i = 0; i < num; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", number.Sum());
            Console.WriteLine("Min = {0}", number.Min());
            Console.WriteLine("Max = {0}", number.Max());
            Console.WriteLine("Average = {0}", number.Average());
        }
    }
}