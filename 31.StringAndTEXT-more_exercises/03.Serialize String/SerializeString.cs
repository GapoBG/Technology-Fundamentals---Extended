using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Serialize_String
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string empty = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (!empty.Contains(input[i]))
                {
                    string output = input[i] + ":";
                    int index = 0;
                    for (int j = 0; j < input.Length; j++)
                    {
                        index = input.IndexOf(input[i], index);
                        if (index == -1)
                        {
                            break;
                        }

                        output += index + "/";
                        index++;
                    }
                    Console.WriteLine(output.Trim('/'));
                    empty += input[i];
                }
            }
        }
    }
}
