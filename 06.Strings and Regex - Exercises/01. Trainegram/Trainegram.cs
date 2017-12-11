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
        string regex = @"^(<\[[^A-Za-z0-9]*\][\.]{1})([\.]{1}\[[A-Za-z0-9]*\][\.]{1})*$";
        string input = String.Empty;
        while ((input = Console.ReadLine()) != "Traincode!")
        {
            Match train = Regex.Match(input, regex);

            if (train.Success)
            {
                Console.WriteLine(input);
            }
            
        }


    }
}
