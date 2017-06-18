using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MultiplyArrayDoubles
{
    class MultiplyArray
    {
        static void Main(string[] args)
        {
            double[] numArray = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double multiplyNum = double.Parse(Console.ReadLine());
            double[] newArray = new double[numArray.Length];

            for (int i = 0; i < numArray.Length; i++)
            {
                newArray[i] = numArray[i] * multiplyNum;
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
