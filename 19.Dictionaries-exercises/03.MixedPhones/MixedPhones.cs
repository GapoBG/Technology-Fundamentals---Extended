using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, long>();

            var input = Console.ReadLine();
            while (input != "Over")
            {
                var data = input.Split(' ').ToArray();
                var name = data[0];
                var number = data[data.Length-1];

                var value = 0l;
                if (long.TryParse(name, out value))
                {
                    phoneBook[number] = value;
                }
                else if (long.TryParse(number, out value))
                {
                    phoneBook[name] = value;
                }
                input = Console.ReadLine();
            }

            foreach (var item in phoneBook)
            {
                var name = item.Key;
                var phoneNum = item.Value;

                Console.WriteLine($"{name} -> {phoneNum}");
            }
        }
    }
}
