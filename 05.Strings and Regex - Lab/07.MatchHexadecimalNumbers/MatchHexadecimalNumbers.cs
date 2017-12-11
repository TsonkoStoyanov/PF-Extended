using System;
using System.Text.RegularExpressions;
using System.Linq;

public class Example
{
    public static void Main()
    {
        string pattern = @"\b(?:0x)*[0-9A-F]+\b";
        string input = Console.ReadLine();

        var numbers = Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(a => a.Value)
            .ToArray();

        Console.WriteLine(string.Join(" ", numbers));
    }
}
