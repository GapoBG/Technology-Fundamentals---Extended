using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MirrorImage
{
    class MirrorImage
    {
        static void Main(string[] args)
        {
            string[] element = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (true)
            {
                string position = Console.ReadLine();
                if (position == "Print")
                {
                    break;
                }
                int index = int.Parse(position);

                for (int i = 0; i < index/2; i++)
                {
                    string temp = element[i];
                    element[i] = element[index - i - 1];
                    element[index - i - 1] = temp;
                }
                Array.Reverse(element);
                for (int i = 0; i < (element.Length-1-index)/2; i++)
                {
                    string temp = element[i];
                    element[i] = element[(element.Length - 2 - index - i)];
                    element[(element.Length - 2 - index - i)] = temp;
                }
                Array.Reverse(element);              
            }
            Console.WriteLine(string.Join(" ", element));
        }
    }
}
