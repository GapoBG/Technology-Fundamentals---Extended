using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EmployeeData
{
    class EmplyeeData
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int IDnumber = int.Parse(Console.ReadLine());
            decimal Salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Employee ID: {0:d8}", IDnumber);
            Console.WriteLine("Salary: {0:f2}", Salary);
        }
    }
}
