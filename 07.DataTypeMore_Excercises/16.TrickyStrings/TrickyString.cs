using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.TrickyStrings
{
    class TrickyString
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string output = "";
            int counter = 0;

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                output += word;
                counter++;
                if (counter == number)
                {
                    break;
                }
                output += delimiter;
            }
            Console.WriteLine(output);
        }
    }
}
