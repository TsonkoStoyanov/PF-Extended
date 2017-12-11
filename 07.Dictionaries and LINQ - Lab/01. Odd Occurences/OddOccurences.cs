using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddOccurences
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .ToLower().Split(' ');
        Dictionary<string, int> occurence = new Dictionary<string, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!occurence.ContainsKey(input[i]))
            {
                occurence.Add(input[i], 0);
            }

            occurence[input[i]]++;
        }
        List<string> oddOccurence = new List<string>();

        foreach (var pair in occurence.Where(x=>x.Value % 2 !=0))
        {
            oddOccurence.Add(pair.Key);
        }
        Console.WriteLine(string.Join(", ", oddOccurence));
    }
}
