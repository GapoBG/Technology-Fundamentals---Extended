using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequencies
{
    class DecodeRadioFreq
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();
            List<int> outputChar = new List<int>();
            List<int> inputNumber = new List<int>();
            List<int> temp = new List<int>();

            ExtractTheInts(input, inputNumber);
            RemoveZero(inputNumber);
            ReSort(outputChar, inputNumber, temp);

            for (int i = 0; i < outputChar.Count; i++)
            {
                Console.Write((char)outputChar[i]);
            }
            Console.WriteLine();
        }

        private static void ReSort(List<int> outputChar, List<int> inputNumber, List<int> temp)
        {
            for (int i = 0; i < inputNumber.Count; i++)
            {
                if (i % 2 == 0)
                {
                    outputChar.Add(inputNumber[i]);
                }
            }
            for (int i = 0; i < inputNumber.Count; i++)
            {
                if (i % 2 != 0)
                {
                    temp.Add(inputNumber[i]);
                }
            }
            temp.Reverse();
            for (int i = 0; i < temp.Count; i++)
            {
                outputChar.Add(temp[i]);
            }
        }

        private static void RemoveZero(List<int> inputNumber)
        {
            for (int i = 0; i < inputNumber.Count; i++)
            {
                if (inputNumber[i] == 0)
                {
                    inputNumber.Remove(inputNumber[i]);
                    i--;
                }
            }
        }

        private static void ExtractTheInts(List<string> input, List<int> inputNumbers)
        {
            for (int i = 0; i < input.Count; i++)
            {
                string numbers = "";
                for (int j = 0; j < input[i].Length; j++)
                {
                    if ((input[i])[j] != '.')
                    {
                        numbers += (input[i])[j];
                    }
                    else
                    {
                        inputNumbers.Add(int.Parse(numbers));
                        numbers = "";
                    }
                }
                inputNumbers.Add(int.Parse(numbers));
            }
        }
    }
}
