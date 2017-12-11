using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestNNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int top = int.Parse(Console.ReadLine());

        numbers.Sort();
        numbers.Reverse();

        for (int i = 0; i < top; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
        Console.WriteLine();
    }
}
