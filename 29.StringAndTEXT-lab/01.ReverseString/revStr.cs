using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class revStr
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] result = text.ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(result);  
        }
    }
}
