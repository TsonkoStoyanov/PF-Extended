using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Trainegram
{
    static void Main()
    {
        string pattern = @"^<\[[^A-Za-z0-9]*]\.{1}(.{1}\[[A-Za-z0-9]*].{1})*$";
        string input = string.Empty;
        List<string> trains = new List<string>();

        while ((input= Console.ReadLine())!= "Traincode!")
        {
            if (Regex.IsMatch(input, pattern))
            {
                trains.Add(input);
            }
        }
        Console.WriteLine(string.Join($"{Environment.NewLine}", trains));
    }
}
