using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            var stringBuillder = new StringBuilder();
            var inputString = Console.ReadLine();
            var currentString = "";

            while (inputString != "end")
            {
                currentString = stringBuillder.AppendLine(inputString).ToString();
                inputString = Console.ReadLine();
            }

            var regex = new Regex(@"<a\s*href=(.+?)>(.+?)<\/a>");
            var textToReplace = regex.Match(currentString);
            var replacement = "[URL href=$1]$2[/URL]";
            var replaced = regex.Replace(textToReplace.Value, replacement);
            var result = currentString.Replace(textToReplace.Value, replaced);
            Console.WriteLine(result);
        }
    }
}
