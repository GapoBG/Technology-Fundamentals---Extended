using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerInsertion
{
    class IntInsert
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string number = Console.ReadLine();
            while (number != "end")
            {
                var digitOne = number[0];
                numList.Insert(int.Parse(digitOne.ToString()), int.Parse(number));
                number = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}

 