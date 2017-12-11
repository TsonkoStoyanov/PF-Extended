using System;
using System.Collections.Generic;
using System.Linq;

class CODEPhoenixOscarRomeoNovember
{
    static void Main()
    {
        string input = string.Empty;
        Dictionary<string, List<string>> creatures = new Dictionary<string, List<string>>();

        while ((input = Console.ReadLine()) != "Blaze it!")
        {
            string[] tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            string creature = tokens[0];
            string squadMate = tokens[1];

            if (creature.Equals(squadMate))
            {
                continue;
            }

            if (!creatures.ContainsKey(creature))
            {
                creatures.Add(creature, new List<string>());
            }

            if (!creatures[creature].Contains(squadMate))
            {
                creatures[creature].Add(squadMate);
            }
        }
        var result = new Dictionary<string, List<String>>();
        foreach (var pair in creatures)
        {
            result.Add(pair.Key, new List<string>());

            foreach (var item in pair.Value)
            {
                if (creatures.ContainsKey(item) && creatures[item].Contains(pair.Key))
                {
                    continue;
                }
                else
                {
                    result[pair.Key].Add(item);
                }
            }
        }
        foreach (var pair in result.OrderByDescending(c=>c.Value.Count))
        {
            Console.WriteLine($"{pair.Key} : {pair.Value.Count}");
        }
    }
}

