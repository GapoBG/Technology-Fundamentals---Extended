using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCIIstring
{
    class ASCIIstring
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var currentCharInString = "";

            for (int i = 1; i <= num; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                char currentChar = (char)currentNumber;
                
                currentCharInString += currentChar;                
            }
            Console.WriteLine(currentCharInString);
        }
    }
}
