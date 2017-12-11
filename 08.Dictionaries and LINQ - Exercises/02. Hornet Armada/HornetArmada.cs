using System;
using System.Collections.Generic;
using System.Linq;

class HornetArmada
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var legions = new Dictionary<string, Dictionary<string, long>>();
        var legionsWithactivity = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', ':', '=', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            int legionActivity = int.Parse(input[0]);
            string legionName = input[1];
            string soldierType = input[2];
            long soldierCount = long.Parse(input[3]);

            if (!legions.ContainsKey(legionName))
            {
                legions.Add(legionName, new Dictionary<string, long>());
                legionsWithactivity.Add(legionName, legionActivity);
            }
            if (legionsWithactivity[legionName] < legionActivity)
            {
                legionsWithactivity[legionName] = legionActivity;
            }
            if (!legions[legionName].ContainsKey(soldierType))
            {
                legions[legionName].Add(soldierType, 0);
            }
            legions[legionName][soldierType] += soldierCount;
        }
        string[] tokens = Console.ReadLine().Split('\\');

        if (tokens.Length > 1)
        {
            int activity = int.Parse(tokens[0]);
            string soldierType = tokens[1];
            foreach (var legionEntry in legions
                .Where(legion => legion.Value.ContainsKey(soldierType))
                .OrderByDescending(legion => legion.Value[soldierType]))
            {
                if (legionsWithactivity[legionEntry.Key] < activity)
                {
                    Console.WriteLine("{0} -> {1}", legionEntry.Key, legions[legionEntry.Key][soldierType]);
                }
            }
        }
         string soldiersType = tokens[0];

       
        foreach (var legionEntry in legionsWithactivity.OrderByDescending(legion => legion.Value))
        {
        
            if (legions[legionEntry.Key].ContainsKey(soldiersType))
            {
                Console.WriteLine("{0} : {1}", legionEntry.Value, legionEntry.Key);
            }
        }
    }
}
