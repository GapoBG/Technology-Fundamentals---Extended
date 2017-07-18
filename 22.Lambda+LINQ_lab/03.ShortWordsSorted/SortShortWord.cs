using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShortWordsSorted
{
    class SortShortWord
    {
        static void Main(string[] args)
        {
            //   char[] seperators = new char[]
            //        { '.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            char[] seperators = ".,:;()[]\"'/\\!? ".ToCharArray();
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(seperators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ", words));



        }
    }
}
