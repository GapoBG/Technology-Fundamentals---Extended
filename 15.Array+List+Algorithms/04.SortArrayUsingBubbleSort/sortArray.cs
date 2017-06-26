using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortArrayUsingBubbleSort
{
    class sortArray
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numberList.Sort();

            Console.WriteLine(string.Join(" ", numberList));
            
        }
    }
}
