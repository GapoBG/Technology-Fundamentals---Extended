using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var matchSum = int.Parse(Console.ReadLine());
            var checkSum = 0;
            var rowCount = 0;
            var str = string.Empty;

            Char[] nucleicAcid = { 'A', 'C', 'G', 'T' };
            int[] nucleicAcidValue = { 1, 2, 3, 4 };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {

                        checkSum = nucleicAcidValue[i] + nucleicAcidValue[j] + nucleicAcidValue[k];

                        if (checkSum >= matchSum)
                        {
                            str = "O" + nucleicAcid[i] + nucleicAcid[j] + nucleicAcid[k] + "O" + " ";
                        }
                        else
                        {
                            str = "X" + nucleicAcid[i] + nucleicAcid[j] + nucleicAcid[k] + "X" + " ";
                        }
                        Console.Write(str);
                        rowCount++;
                        if (rowCount >= 4)
                        {
                            Console.WriteLine();
                            rowCount = 0;
                        }
                    }
                }
            }         
        }
    }
}