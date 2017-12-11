using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PokemonDontGo
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        long sum = 0;

        while (numbers.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());

            int IndexValue = 0;
            bool isChanged = false;

            if (index >= numbers.Count)
            {
                IndexValue = numbers[numbers.Count - 1];
                numbers[numbers.Count - 1] = numbers[0];
                isChanged = true;
            }
            if (index < 0)
            {
                IndexValue = numbers[0];
                numbers[0] = numbers[numbers.Count - 1];
                isChanged = true;
            }
            if (!isChanged)
            {
                IndexValue = numbers[index];
                numbers.RemoveAt(index);
            }

            sum += IndexValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > IndexValue)
                {
                    numbers[i] -= IndexValue;
                }
                else
                {
                    numbers[i] += IndexValue;
                }
            }
        }
        Console.WriteLine(sum);
    }
}
