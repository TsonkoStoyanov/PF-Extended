using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string message = @"^([\d]+) <-> ([0-9A-Za-z]+)$";
        string broadcast = @"^([\D]+) <-> ([0-9A-Za-z]+)$";

        Regex regexMessage = new Regex(message);
        Regex regexBroadcast = new Regex(broadcast);

        List<string> messages = new List<string>();
        List<string> broadcasts = new List<string>();

        string input = String.Empty;

        while ((input = Console.ReadLine()) != "Hornet is Green")
        {
            if (regexMessage.IsMatch(input))
            {
                Match match = regexMessage.Match(input);

                string recipientCode = string.Join("", match.Groups[1].Value.Reverse());
                string messageValue = match.Groups[2].Value;

                messages.Add(recipientCode + " -> " + messageValue);
            }
            if (regexBroadcast.IsMatch(input))
            {
                Match match = regexBroadcast.Match(input);
                string messageValue = match.Groups[1].Value;
                string frequency = DecryptFrequency(match.Groups[2].Value);
                broadcasts.Add(frequency + " -> " + messageValue);
            }
        }
        Console.WriteLine("Broadcasts:");
        if (broadcasts.Count > 0)
        {
            Console.WriteLine(string.Join($"{Environment.NewLine}", broadcasts));
        }
        else
        {
            Console.WriteLine("None");
        }

        Console.WriteLine("Messages:");

        if (messages.Count > 0)
        {
            Console.WriteLine(string.Join($"{Environment.NewLine}", messages));
        }
        else
        {
            Console.WriteLine("None");
        }

    }

    private static string DecryptFrequency(string value)
    {
        char[] result = value.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLower(result[i]))
            {
                result[i] = char.ToUpper(result[i]);
            }
            else if(char.IsUpper(result[i]))
            {
                result[i] = char.ToLower(result[i]);
            }
        }
        return string.Join("", result);
    }
}
