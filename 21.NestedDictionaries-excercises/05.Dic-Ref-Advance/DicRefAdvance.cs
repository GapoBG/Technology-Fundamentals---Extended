using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dic_Ref_Advance
{
    class DicRefAdvance
    {
        static void Main(string[] args)
        {
            var byNameValue = new Dictionary<string, List<int>>();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                List<string> temp = inputLine
                    .Split(new char[] { ' ', ',', '-', '>' })
                    .ToList();
                var first = temp[0];
                var last = temp[temp.Count - 1];
                temp.Remove(first);
                var num = 0;
                var listFromNumber = new List<int>();

                if (!int.TryParse(temp[temp.Count - 1], out num))
                {
                    if (!byNameValue.ContainsKey(last))
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        byNameValue[first] = new List<int>(byNameValue[last]);
                    }
                }
                else
                {
                    listFromNumber = TakeTheNumber(temp);
                    if (!byNameValue.ContainsKey(first))
                    {
                        byNameValue[first] = new List<int>();
                        byNameValue[first] = listFromNumber;
                    }
                    else
                    {
                        byNameValue[first].AddRange(listFromNumber);
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var name in byNameValue)
            {
                Console.WriteLine($"{name.Key} === {string.Join(", ", name.Value)}");
            }

        }

        private static List<int> TakeTheNumber(List<string> numbers)
        {
            var listFromNum = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var number = 0;
                if (int.TryParse(numbers[i], out number))
                {
                    listFromNum.Add(int.Parse(numbers[i]));
                }
                else
                {
                    continue;
                }
            }
            return listFromNum;
        }
    }
}
