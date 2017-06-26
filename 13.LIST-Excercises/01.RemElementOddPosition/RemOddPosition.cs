using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemElementOddPosition
{
    class RemOddPosition
    {
        static void Main(string[] args)
        {
            List<string> letterString = Console.ReadLine()
                .Split(' ')
                .ToList();

            for (int i = 0; i < letterString.Count; i+=2)
            {
                letterString.Remove(letterString[i]);
                i--;
            }
            Console.WriteLine(string.Join("", letterString));
        }
    }
}
