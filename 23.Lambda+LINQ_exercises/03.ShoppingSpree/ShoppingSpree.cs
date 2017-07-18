using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double sum = 0;

            double minPrice = double.MaxValue;
            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string productName = tokens[0];
                double productPrice = double.Parse(tokens[1]);
                if (products.ContainsKey(productName))
                {
                    if (products[productName] > productPrice)
                    {
                        products[productName] = productPrice;
                    }
                }
                else if (!products.ContainsKey(productName))
                {
                    products.Add(productName, productPrice);
                }

                input = Console.ReadLine();
            }

            Dictionary<string, double> sortedProducts =
                products
                .OrderBy(n => n.Key.Length)
                .OrderByDescending(p => p.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (double price in sortedProducts.Values)
            {
                sum += price;
            }

            if (sum > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (KeyValuePair<string, double> item in sortedProducts)
                {
                    string productName = item.Key;
                    double productPrice = item.Value;

                    Console.WriteLine($"{productName} costs {productPrice:f2}");
                }
            }

        }
    }
}