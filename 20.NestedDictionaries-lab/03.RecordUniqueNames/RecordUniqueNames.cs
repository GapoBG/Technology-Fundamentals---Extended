using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                if (!names.Contains(name))
                {
                    names.Add(name);
                }
            }
            Console.WriteLine(string.Join("\n", names));
        }
    }
}
