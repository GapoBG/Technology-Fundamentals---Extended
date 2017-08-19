using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DiamondProblem
{
    class DiamondProb
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isFound = false;
            int leftIndex = -1;
            int rightIndex = -1;

            while ((leftIndex = input.IndexOf('<', leftIndex + 1)) > -1
                && (rightIndex = input.IndexOf('>', leftIndex + 1)) > -1)
            {
                string diamondContent = input.Substring(leftIndex + 1, rightIndex - leftIndex);
                int carats = FindeCarats(diamondContent);
                Console.WriteLine($"Found {carats} carat diamond");
                isFound = true;
            }
            if (!isFound)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        private static int FindeCarats(string diamondContent)
        {
            int carats = 0;
            foreach (var item in diamondContent)
            {
                if (char.IsDigit(item))
                {
                    carats += int.Parse(item.ToString());
                }
            }
            return carats;
        }
    }
}
