using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FindLetter
{
    class FindeLetter
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string[] command = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var letter = char.Parse(command[0]);
            var counter = int.Parse(command[1]);
            int index = -1;

            for (int i = 0; i < counter; i++)
            {
                if (index > inputText.Length)
                {
                    break;
                }
                index += 1;
                index = inputText.IndexOf(letter, index);
            }
            if (index == -1)
            {
                Console.WriteLine("Find the letter yourself!");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
