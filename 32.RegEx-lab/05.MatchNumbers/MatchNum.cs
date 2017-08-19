using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.MatchNumbers
{
    class MatchNum
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");
            var currentNum = regex.Matches(Console.ReadLine());

            foreach (var item in currentNum)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
