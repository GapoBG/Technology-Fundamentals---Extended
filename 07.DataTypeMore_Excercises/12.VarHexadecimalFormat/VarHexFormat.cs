﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.VarHexadecimalFormat
{
    class VarHexFormat
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int convertInt = Convert.ToInt32(input, 16);
            Console.WriteLine(convertInt);
        }
    }
}
