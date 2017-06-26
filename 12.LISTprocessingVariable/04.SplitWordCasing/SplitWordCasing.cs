using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitWordCasing
{
    class SplitWordCasing
    {
        static void Main(string[] args)
        {

                char[] seperators = new char[]
                    {
                    ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' '
                    };
                List<string> word = Console.ReadLine()
                    .Split(seperators, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                List<string> lowerCaseList = new List<string>();
                List<string> upperCaseList = new List<string>();
                List<string> mixedCaseList = new List<string>();

            foreach (var w in word)
                {
                    var type = GetWordType(w);
                    if (type == WordType.UpperCase)
                    {
                        upperCaseList.Add(w);
                    }
                    else if (type == WordType.LowerCase)
                    {
                        lowerCaseList.Add(w);
                    }
                    else
                        mixedCaseList.Add(w);
                }
                Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseList));
                Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseList));
                Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseList));
            }

            enum WordType { UpperCase, MixedCase, LowerCase }
            static WordType GetWordType(string word)
            {
                var lowerLetters = 0;
                var upperLetters = 0;
                foreach (var l in word)
                {
                    if (char.IsUpper(l))
                    {
                        upperLetters++;
                    }
                    else if (char.IsLower(l))
                    {
                        lowerLetters++;
                    }
                }
                if (upperLetters == word.Length)
                {
                    return WordType.UpperCase;
                }
                if (lowerLetters == word.Length)
                {
                    return WordType.LowerCase;
                }
                return WordType.MixedCase;
            }
        }
    }


