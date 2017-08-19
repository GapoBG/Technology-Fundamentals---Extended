using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                var placeHolder = input[0].Trim();
                var wordForReplace = input[1]
                    .Trim()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < wordForReplace.Length; i++)
                {
                    var elements = "{" + i + "}";
                    placeHolder = placeHolder.Replace(elements, wordForReplace[i]);
                }
                Console.WriteLine(placeHolder);

                input = Console.ReadLine().Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
