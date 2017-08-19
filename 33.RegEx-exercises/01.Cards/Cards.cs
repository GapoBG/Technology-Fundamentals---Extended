using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            var patters = @"(?<![0-9])(?:([2-9]|10)|(A|K|Q|J))+(S|H|D|C)";
            var regex = new Regex(patters);
            var validCardsAre = regex.Matches(Console.ReadLine());

            var isFirst = true;
            foreach (var card in validCardsAre)
            {
                if (isFirst)
                {
                    Console.Write(card);
                    isFirst = false;
                    continue;
                }
                Console.Write($", {card}");
            }
            Console.WriteLine();
        }
    }
}
