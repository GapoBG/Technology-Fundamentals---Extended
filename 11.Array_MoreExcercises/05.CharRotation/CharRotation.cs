using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharRotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            string inpitStr = Console.ReadLine();

            int[] inputNum = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            char[] result = new char[inputNum.Length];

            for (int i = 0; i < inputNum.Length; i++)
            {
                if (inputNum[i] % 2 == 0)
                {
                    result[i] = (char)(inpitStr[i] - inputNum[i]);
                }

                else
                {
                    result[i] = (char)(inpitStr[i] + inputNum[i]);
                }
            }
            Console.WriteLine(string.Join("",result));
        }        
    }
}
