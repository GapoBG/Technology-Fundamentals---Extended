using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _test
{
    class test
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+\s{1}\b[A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            MatchCollection names = regex.Matches(Console.ReadLine());

            foreach (Match m in names)
            {
                Console.Write(m.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
