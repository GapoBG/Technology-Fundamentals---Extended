using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})");
            var currentDate = regex.Matches(Console.ReadLine());

            foreach (Match item in currentDate)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
