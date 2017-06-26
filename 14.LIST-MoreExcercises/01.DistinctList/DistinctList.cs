using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DistinctList
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numberList.Count; i++)
            {
                for (int j = i+1 ; j < numberList.Count; j++)
                {
                    if (numberList[i] == numberList[j])
                    {
                        numberList.RemoveAt(j);
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
