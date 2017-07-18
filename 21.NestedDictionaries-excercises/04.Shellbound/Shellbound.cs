using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var dataDiction = new Dictionary<string, HashSet<long>>();
            var inputStr = Console.ReadLine();

            while (inputStr != "Aggregate")
            {
                string[] tempStr = inputStr.Split(' ').ToArray();
                string region = tempStr[0];
                long size = long.Parse(tempStr[1]);
                if (!dataDiction.ContainsKey(region))
                {
                    dataDiction[region] = new HashSet<long>();
                }
                dataDiction[region].Add(size);
                inputStr = Console.ReadLine();
            }
            foreach (var region in dataDiction)
            {
                var sum = region.Value.Sum();
                var result = sum - sum / region.Value.Count;
                Console.WriteLine($"{region.Key} -> {string.Join(", ",region.Value)} ({result})");
            }
        }
    }
}
