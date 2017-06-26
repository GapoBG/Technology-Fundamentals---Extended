using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendList
{
    class AppendList
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|')
                .ToList();
            numbers.Reverse();

            List<string> newNumber = new List<string>();

            foreach (var item in numbers)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        newNumber.Add(num);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", newNumber));

        }
    }
}
