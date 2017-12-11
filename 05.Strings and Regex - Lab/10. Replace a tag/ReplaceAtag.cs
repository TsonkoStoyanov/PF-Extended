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
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "end")
        {

            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";
            string replaced = Regex.Replace(
                input, pattern, replacement);
            Console.WriteLine(replaced);

        }
    }
}
