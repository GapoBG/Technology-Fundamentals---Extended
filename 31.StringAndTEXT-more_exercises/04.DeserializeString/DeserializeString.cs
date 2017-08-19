using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DeserializeString
{
    class DeserializeString
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder output = new StringBuilder(new string(' ', 200));

            while (line != "end")
            {
                string[] tokens = line.Split(new[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);

                string symbol = tokens[0];
                int[] indexes = tokens.Skip(1).Select(int.Parse).ToArray();

                for (int i = 0; i < indexes.Length; i++)
                {
                    int indeX = indexes[i];
                    output.Replace(" ", symbol, indeX, 1);
                }
                line = Console.ReadLine();
            }

            Console.WriteLine(output.ToString().Trim());
        }
    }
}
