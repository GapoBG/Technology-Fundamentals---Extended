using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumber
{
    class GameNumber
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int startGen = 0;
            int endGen = 0;
            int count = 0;

            if (firstNum > secondNum)
            {
                startGen = firstNum;
                endGen = secondNum;
            }
            else
            {
                startGen = firstNum;
                endGen = secondNum;
            }

            for (int i = startGen; i <= endGen; i++)
            {
                for (int j = startGen; j <= endGen; j++)
                {
                    count++;
                    
                    if (i + j == magicNum)
                    {
                        firstNum = i;
                        secondNum = j;
                    }
                }
            }
                    
            if (firstNum + secondNum == magicNum)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", firstNum, secondNum, magicNum);
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }            
        }
    }
}
