using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, int> result = new Dictionary<string, int>();

            while (inputLine != "shopping time")
            {
                var token = inputLine.Split(' ');
                var product = token[1];
                var quantity = int.Parse(token[2]);

                if (!result.ContainsKey(product))
                {
                    result[product] = 0;
                }
                result[product] += quantity;                
                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine();
            while (inputLine != "exam time")
            {
                var token = inputLine.Split(' ');
                var product = token[1];
                var quantity = int.Parse(token[2]);

                if (!result.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }

                else
                {
                    if (result[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        result[product] -= quantity;
                        if (result[product] < 0)
                        {
                            result[product] = 0;
                        }
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var pair in result)
            {
                if (pair.Value > 0)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }

            }
        }
    }
}
