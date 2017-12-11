using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string regex = @"\+359([\s-]?)2\1[0-9]{3}\1[0-9]{4}\b";
        string input = Console.ReadLine();

        var phones = Regex.Matches(input, regex);

        var matchedPhones = phones.Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));


    }
}