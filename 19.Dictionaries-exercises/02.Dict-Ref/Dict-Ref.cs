using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resultDict = new Dictionary<string, int>();

            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] token = line.Split();

                var firstElement = token[0];
                var lastElement = token[token.Length - 1];

                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var referencedValue = resultDict[lastElement];
                        resultDict[firstElement] = referencedValue;
                    }
            }
                line = Console.ReadLine();
            }

            foreach (var itemPricePair in resultDict)
            {
                var item = itemPricePair.Key;
                var price = itemPricePair.Value;

                Console.WriteLine($"{item} === {price}");
            }
        }
    }
}
