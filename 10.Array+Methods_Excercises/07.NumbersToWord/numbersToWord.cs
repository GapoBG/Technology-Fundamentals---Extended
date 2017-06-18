using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NumbersToWord
{
    class numbersToWord
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            LeterSize(numberInput);
        }

        private static void LeterSize(int number)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int[] arrayNum = new int[number];

            // name of number
            if (num == 1)
            {
                string one = "one";
            }
            else if (number == 2)
            {
                string two = "two";
            }
            else if (number == 3)
            {
                string three = "three";
            }
            else if (number == 4)
            {
                string four = "four";
            }
            else if (number == 5)
            {
                string five = "five";
            }
            else if (number == 6)
            {
                string six = "six";
            }
            else if (number == 7)
            {
                string seven = "seven";
            }
            else if (number == 8)
            {
                string eight = "eight";
            }
            else if (number == 9)
            {
                string nine = "nine";
            }
            else if (number == 20)
            {
                string twenty = "twenty";
            }
            else if (number == 30)
            {
                string thirty = "thirty";
            }

            // input number
            for (int i = 0; i < number; i++)
            {
                arrayNum[i] = int.Parse(Console.ReadLine()); 
            }
// too large or too small
            if (number > 999)
            {
                Console.WriteLine("too large");
            }
            else if (number < -999)
            {
                Console.WriteLine("too small");
            }
// between 101 <=> 999
            else if (number > 100 && number <= 999)
            {

                num1 = number / 100;
                Console.WriteLine("");

            }
        }
    }
}
