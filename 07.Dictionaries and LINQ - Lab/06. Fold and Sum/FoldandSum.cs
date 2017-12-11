using System;
using System.Collections.Generic;
using System.Linq;

class FoldandSum
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int k = numbers.Count / 4;

        List<int> left = new List<int>();
        List<int> right = new List<int>();
        List<int> middle = new List<int>();

        left = numbers.Take(k).Reverse().ToList();
        middle = numbers.Skip(k).Take(2 * k).ToList();
        numbers.Reverse();
        right = numbers.Take(k).ToList();
        var row1 = left.Concat(right);

        
        Console.WriteLine(string.Join(" " ,row1.Select((x, index) => x + middle[index])));

    }
}
