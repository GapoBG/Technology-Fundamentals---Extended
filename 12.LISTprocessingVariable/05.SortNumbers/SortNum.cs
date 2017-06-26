using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class SortNum
    {
        static void Main(string[] args)
        {
            List<double> numberList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            numberList.Sort();

            Console.WriteLine(string.Join(" <= ", numberList));
        }
    }
}
