using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();

        int count = 0;
        int index = text.IndexOf(pattern);
        while (index != -1)
        {
            count++;
            index = text.IndexOf(pattern, index + 1);
        }
        Console.WriteLine(count);
    }
}

