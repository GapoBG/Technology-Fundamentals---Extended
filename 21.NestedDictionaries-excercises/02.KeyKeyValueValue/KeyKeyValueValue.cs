using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KeyKeyValueValue
{
    class KeyKeyValueValue
    {
        static void Main(string[] args)
        {
            string inputKey = Console.ReadLine();
            string inputValue = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                string[] inputToken = Console.ReadLine()
                    .Split(new string[] {" => "},StringSplitOptions.RemoveEmptyEntries).ToArray();
                string myKey = inputToken[0];
                string[] myValue = inputToken[1].Split(';');

                if (myKey.Contains(inputKey))
                {
                    result.Add(myKey, new List<string>());
                    foreach (var v in myValue)
                    {
                        if (v.Contains(inputValue))
                        {
                            result[myKey].Add(v);
                        }
                    }
                }
            }

            foreach (var element in result)
            {
                Console.WriteLine($"{element.Key}:");
                Console.WriteLine($"-{string.Join("\n-", element.Value)}");
            }
            
        }
    }
}
