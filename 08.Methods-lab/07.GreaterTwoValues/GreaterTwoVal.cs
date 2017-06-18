using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterTwoValues
{
    class GreaterTwoVal
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();

            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    int maxInt = getMaxInt(num1, num2);
                    Console.WriteLine(maxInt);
                    break;

                case "string":
                    string word1 = Console.ReadLine();
                    string word2 = Console.ReadLine();
                    string maxString = getMaxStr(word1, word2);
                    Console.WriteLine(maxString);
                    break;

                case "char":
                    char inputA = char.Parse(Console.ReadLine());
                    char inputB = char.Parse(Console.ReadLine());
                    char maxChar = getmaxChar(inputA, inputB);
                    Console.WriteLine(maxChar);
                    break;

            }
          

        }

        private static char getmaxChar(char inputA, char inputB)
        {
            if (inputA.CompareTo(inputB) >= 0)
            {
                return inputA;
            }
            else
            {
                return inputB;
            }
        }

        private static string getMaxStr(string word1, string word2)
        {
            if (word1.CompareTo(word2) >= 0)
            {
                return word1;
            }
            else
            {
                return word2;
            }
        }

        private static int getMaxInt(int num1, int num2)
        {

            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return  num2;
            }
        }
    }
}
