using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HornetAssault
{
    static void Main(string[] args)
    {
        long[] beehives = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToArray();

        List<long> hornets = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToList();

        for (int i = 0; i < beehives.Length; i++)
        {
            long totalHornets = hornets.Sum();

            if (hornets.Count != 0)
            {
                if (totalHornets > beehives[i])
                {
                    beehives[i] -= totalHornets;
                }
                else
                {
                    beehives[i] -= totalHornets;
                    hornets.RemoveAt(0);
                }
            }
            else
            {
                break;
            }
        }
        List<long> beehivesLeft = beehives.Where(x => x > 0).ToList();

        if (beehivesLeft.Count != 0)
        {
            Console.WriteLine(string.Join(" ", beehivesLeft));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));
        }
    }
}
