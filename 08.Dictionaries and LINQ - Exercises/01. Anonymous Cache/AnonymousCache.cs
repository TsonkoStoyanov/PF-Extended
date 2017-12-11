using System;
using System.Collections.Generic;
using System.Linq;

class AnonymousCache
{
    static void Main()
    {
        string input = string.Empty;

        var cache = new Dictionary<string, Dictionary<string, long>>();
        var data = new Dictionary<string, Dictionary<string, long>>();

        while ((input = Console.ReadLine()) != "thetinggoesskrra")
        {
            string[] tokens = input.Split(new[] {' ', '|', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
            string dataSet = string.Empty;
            string dataKey = string.Empty;
            long dataSize = 0;

            if (tokens.Length > 1)
            {
                dataKey = tokens[0];
                dataSet = tokens[2];
                dataSize = long.Parse(tokens[1]);

                if (data.ContainsKey(dataSet))
                {
                    if (!data[dataSet].ContainsKey(dataKey))
                    {
                        data[dataSet].Add(dataKey, 0);
                    }
                    data[dataSet][dataKey] += dataSize;
                }
                else
                {
                    if (!cache.ContainsKey(dataSet))
                    {
                        cache.Add(dataSet, new Dictionary<string, long>());
                    }
                    if (!cache[dataSet].ContainsKey(dataKey))
                    {
                        cache[dataSet].Add(dataKey, 0);
                    }
                    cache[dataSet][dataKey] += dataSize;
                }
            }
            else
            {
                dataSet = tokens[0];
                if (!data.ContainsKey(dataSet))
                {
                    if (cache.ContainsKey(dataSet))
                    {
                        data[dataSet] = cache[dataSet];
                    }
                    else
                    {
                        data[dataSet] = new Dictionary<string, long>();
                    }

                }
            }
        }
        if (data.Count > 0)
        {
            var result = data
                .OrderByDescending(ds => ds.Value.Sum(d => d.Value))
                .First();

            Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(d => d.Value)}");

            foreach (var value in result.Value)
            {
                Console.WriteLine("$.{0}", value.Key);
            }
        }
    }
}


