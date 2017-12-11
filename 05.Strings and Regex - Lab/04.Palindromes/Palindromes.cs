using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Palindromes
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        List<string> palindromes = new List<string>();

        foreach (var w in words)
        {
            var reverse = new string(w.Reverse().ToArray());

            if (w==reverse)
            {
                palindromes.Add(w);
            }
        }
        palindromes = palindromes.Distinct().OrderBy(x => x).ToList();

        Console.WriteLine(string.Join(", ", palindromes));
    }

}
