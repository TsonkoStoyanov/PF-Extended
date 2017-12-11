using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class MatchFullName
{
    static void Main()
    {
        string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
        string input = Console.ReadLine();

        MatchCollection matchedNames = Regex.Matches(input, pattern);

        foreach (Match match in matchedNames)
        {
            Console.Write(match.Value + " ");
        }
        Console.WriteLine();
    }
}
