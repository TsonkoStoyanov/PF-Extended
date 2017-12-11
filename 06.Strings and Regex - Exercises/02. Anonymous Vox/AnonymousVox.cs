using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class AnonymousVox
{
    static void Main()
    {
        var regex = @"([A-Za-z]+)(.*)(\1)";

        string encodedMessage = Console.ReadLine();
        string[] placeholders = Console.ReadLine()
            .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

        int placeholdersIndex = 0;

        MatchCollection matches = Regex.Matches(encodedMessage, regex);

        foreach (Match match in matches)
        {
            if (placeholdersIndex > placeholders.Length - 1)
            {
                break;
            }
            encodedMessage = ReplaceFirst(encodedMessage, match.Groups[2].Value, placeholders[placeholdersIndex++]);

        }
        Console.WriteLine(encodedMessage);
    }

    private static string ReplaceFirst(string encodedMessage, string oldValue, string newValue)
    {
        string substringWithOldValue = encodedMessage.Substring(0, encodedMessage.IndexOf(oldValue) + oldValue.Length);

        string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);

        return substringWithNewValue + encodedMessage.Substring(substringWithOldValue.Length);
    }
}
