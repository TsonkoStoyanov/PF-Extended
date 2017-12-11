using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string regex = @"\b(?<day>\d{2})([-\.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        string input = Console.ReadLine();

        foreach (Match m in Regex.Matches(input, regex))
        {
            var day = m.Groups["day"].Value;
            var month = m.Groups["month"].Value;
            var year = m.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");


        }
    }
}
