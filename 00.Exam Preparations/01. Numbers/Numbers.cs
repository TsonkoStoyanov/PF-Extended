using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Numbers
{
    static void Main()
    {
        double[] numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        double averageNumber = (numbers.Sum() / numbers.Length);

        List<double> topNumbers = new List<double>();

        bool isTop = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > averageNumber)
            {
                topNumbers.Add(numbers[i]);
                isTop = true;
            }
        }
        if (isTop)
        {
            var topFive= topNumbers.OrderByDescending(x => x).Take(5);

            Console.WriteLine(string.Join(" ", topFive));
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

