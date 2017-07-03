using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElements
{
    class ShootListElem
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            int counterBang = 0;
            int counterNumN = 0;
            double shots = 0;
            List<int> inputListNumber = new List<int>();

            while (inputData != "stop")
            {
                if (inputData == "bang")
                {
                    counterBang++;
                }
                else
                {
                    int number = Int32.Parse(inputData);
                    inputListNumber.Add(number);
                    counterNumN++;
                }
                inputData = Console.ReadLine();
            }

            inputListNumber.Reverse();

            while (counterBang != 0)
            {
                double avarageNum = 0;
                double sumList = 0;


                for (int i = 0; i < inputListNumber.Count; i++)
                {
                    sumList += inputListNumber[i];
                }
                avarageNum = sumList / inputListNumber.Count;

                for (int i = 0; i < inputListNumber.Count; i++)
                {
                    if (inputListNumber[i] <= avarageNum)
                    {
                        shots = inputListNumber[i];
                        inputListNumber.Remove(inputListNumber[i]);
                        i--;
                        break;
                    }
                }

                for (int i = 0; i < inputListNumber.Count; i++)
                {
                    inputListNumber[i] = inputListNumber[i] - 1;
                }
                counterBang--;

                if (counterNumN != 0)
                {
                    Console.WriteLine("shot {0}", shots);
                    counterNumN--;
                }

            }
            if (inputListNumber.Count < 0)
            {
                Console.WriteLine("you shot them all. last one was {0}", shots);
            }
            else if (inputListNumber.Count == 0)
            {
                Console.WriteLine("nobody left to shoot! last one was {0}", shots);
            }
            else
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", inputListNumber));
            }
        }
    }
}
