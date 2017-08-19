using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class textFilter
    {
        static void Main(string[] args)
        {
            string[] letterFillter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var filter in letterFillter)
            {
                if (text.Contains(filter))
                {
                    text = text.Replace(filter, new string('*', filter.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
