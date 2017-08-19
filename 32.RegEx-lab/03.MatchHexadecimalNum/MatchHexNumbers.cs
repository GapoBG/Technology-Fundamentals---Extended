using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.MatchHexadecimalNum
{
    class MatchHexNumbers
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var regex = new Regex(pattern);
            var result = regex.Matches(Console.ReadLine());

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
