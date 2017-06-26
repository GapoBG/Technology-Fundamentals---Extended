using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            int sequenceCnt = int.Parse(Console.ReadLine());

            List<int> sequence = new List<int>();
            for (int cnt = 0; cnt < sequenceCnt; cnt++)
            {
                sequence = Console.ReadLine()
                    .Split().Select(int.Parse).ToList();
                List<int> modifiedSequence = new List<int>(sequence);
                for (int i = 0; i < primalList.Count; i++)
                {
                    modifiedSequence.RemoveAll(number => number == primalList[i]);
                }
                for (int i = 0; i < sequence.Count; i++)
                {
                    primalList.RemoveAll(number => number == sequence[i]);
                }
                primalList.AddRange(modifiedSequence);
            }
            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}