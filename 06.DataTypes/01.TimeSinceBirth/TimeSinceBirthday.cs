using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TimeSinceBirth
{
    class TimeSinceBirthday
    {
        static void Main(string[] args)
        {
            byte years = byte.Parse(Console.ReadLine());
            int day = years * 365;
            int hours = day * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{years} years = {day} days = {hours} hours = {minutes} minutes.");
        }
    }
}
