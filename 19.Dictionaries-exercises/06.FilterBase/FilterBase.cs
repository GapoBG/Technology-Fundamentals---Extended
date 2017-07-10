using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            var userByAge = new Dictionary<string, int>();
            var userBySelary = new Dictionary<string, double>();
            var userByPlace = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "filter base")
            {
                var temp = input.Split(' ').ToArray();
                var first = temp[0];
                var last = temp[temp.Length - 1];

                var integer = 0;
                var floatpoint = 0.0;

                if (int.TryParse(last, out integer))
                {
                    userByAge[first] = integer;
                }
                else if (double.TryParse(last, out floatpoint))
                {
                    userBySelary[first] = floatpoint;
                }
                else
                {
                    userByPlace[first] = last;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            if (input == "Age")
            {
                foreach (var item in userByAge)
                {
                    Console.WriteLine($"Name: {item.Key}\nAge: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (input == "Salary")
            {
                foreach (var item in userBySelary)
                {
                    Console.WriteLine($"Name: {item.Key}\nSalary: {item.Value.ToString("0.00")}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (var item in userByPlace)
                {
                    Console.WriteLine($"Name: {item.Key}\nPosition: {item.Value}");
                    Console.WriteLine(new string('=',20));
                }
            }
        }
    }
}
