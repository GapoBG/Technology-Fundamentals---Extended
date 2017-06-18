using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotatArrayString
{
    class RotateArray
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] result = new string[stringArray.Length];

            result[0] = stringArray[stringArray.Length - 1];
            for (int i = 0; i < stringArray.Length-1; i++)
            {
                result[i + 1] = stringArray[i];
            }

            Console.Write(String.Join(" ",result));
            Console.WriteLine();
        }
    }
}
