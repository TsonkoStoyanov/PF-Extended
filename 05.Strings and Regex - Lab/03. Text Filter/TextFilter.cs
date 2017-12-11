using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class TextFilter
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(new char[]{',', ' '}, StringSplitOptions
            .RemoveEmptyEntries);
        string text = Console.ReadLine();

        foreach (var w in words)
        {
            text = text.Replace(w, new string('*', w.Length));
        }

        Console.WriteLine(text);
    }
}
