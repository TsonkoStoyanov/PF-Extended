﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddNumbersatOddPositions
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 != 0 && numbers[i] % 2 != 0)
            {
                Console.WriteLine($"Index {i} -> {numbers[i]}");
            }
        }

    }
}
