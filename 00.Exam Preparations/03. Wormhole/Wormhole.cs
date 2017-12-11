using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int countStep = 0;
        int index = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != 0)
            {
                index = numbers[i]-1;
                numbers[i] = 0;
                i = index;
            }
            else
            {
                countStep++;
            }

        }
        Console.WriteLine(countStep);
    }
}
