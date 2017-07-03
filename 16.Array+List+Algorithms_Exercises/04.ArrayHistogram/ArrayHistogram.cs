using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();
            List<string> word = new List<string>();
            List<double> counter = new List<double>();

            SortTheInput(input, word, counter);
            SortData(word, counter);

            for (int i = 0; i < counter.Count; i++)
            {
                Console.Write($"{word[i]} -> {counter[i]} times ");
                Console.WriteLine($"({(counter[i]/input.Count)*100:0.00}%)");
            }
        }

        private static void SortTheInput(List<string> input, List<string> word, List<double> counter)
        {
            int c = 0;
            for (int j = 0; j < input.Count; j++)
            {
                if (word.Contains(input[j]))
                {
                    continue;
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[j] == input[i])
                    {
                        if (word.Contains(input[j]))
                        {
                            continue;
                        }
                        else
                        {
                            c++;
                        }
                    }
                }
                word.Add(input[j]);
                counter.Add(c);
                c = 0;
            }
        }

        private static void SortData(List<string> word, List<double> counter)
        {
            bool isDescendingOrder = false;
            do
            {
                isDescendingOrder = false;
                for (int i = 1; i < counter.Count; i++)
                {
                    double tempValue = 0;
                    string tempWord = "";

                    if (counter[i - 1] < counter[i])
                    {
                        tempValue = counter[i - 1];
                        tempWord = word[i - 1];

                        counter[i - 1] = counter[i];
                        word[i - 1] = word[i];

                        counter[i] = tempValue;
                        word[i] = tempWord;

                        isDescendingOrder = true;
                    }
                }               
            }
            while (isDescendingOrder);
        }
    }
}
