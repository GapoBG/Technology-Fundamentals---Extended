using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AvarageStudentGrades
{
    class StudentGradesAvr
    {
        static void Main(string[] args)
        {
            var StudentGrades = new Dictionary<string, List<double>>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCnt; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!StudentGrades.ContainsKey(name))
                {
                    StudentGrades.Add(name, new List<double>());
                }
                StudentGrades[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> records in StudentGrades)
            {
                string name = records.Key;
                List<double> grade = records.Value;
                double avg = grade.Average();

                Console.Write("{0} -> ", name);
                foreach (double g in grade)
                {
                    Console.Write("{0:f2} ", g);
                }
                Console.WriteLine("(avg: {0:f2})", avg);
            }
        }
    }
}
