using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
     .Split(' ')
     .Select(int.Parse)
     .ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < numberList.Count; i++)
            {
                if (Math.Sqrt(numberList[i]) == (int)Math.Sqrt(numberList[i]))
                {
                    result.Add(numberList[i]);
                }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
