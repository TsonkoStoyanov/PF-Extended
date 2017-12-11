using System;
using System.Collections.Generic;
using System.Linq;

class Trainlands
{
    static void Main()
    {
        var trains = new Dictionary<string, Dictionary<string, long>>();

        string input = String.Empty;

        while ((input = Console.ReadLine()) != "It's Training Men!")
        {
            string[] tokens = input.Split(new[] { '-', '>', ':', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string train = string.Empty;
            string wagon = string.Empty;
            string otherTrain = string.Empty;
            long wagonPower = 0;
            string command = string.Empty;

            if (tokens.Length == 3)
            {
                train = tokens[0];
                wagon = tokens[1];
                wagonPower = long.Parse(tokens[2]);
            }
            else
            {
                train = tokens[0];
                otherTrain = tokens[1];
                command = input.Contains("=") ? "copy" : "transfer";
            }
            switch (command)
            {
                case "copy":
                    if (!trains.ContainsKey(train))
                    {
                        trains.Add(train, new Dictionary<string, long>());
                    }
                    trains[train].Clear();
                    foreach (var pair in trains[otherTrain])
                    {
                        trains[train].Add(pair.Key, pair.Value);
                    }
                    break;
                case "transfer":
                    if (!trains.ContainsKey(train))
                    {
                        trains.Add(train, new Dictionary<string, long>());
                    }
                    foreach (var pair in trains[otherTrain])
                    {
                        trains[train].Add(pair.Key, pair.Value);
                    }
                    trains.Remove(otherTrain);
                    break;
                default:
                    if (!trains.ContainsKey(train))
                    {
                        trains.Add(train, new Dictionary<string, long>());
                    }
                    trains[train].Add(wagon, wagonPower);
                    break;
            }
        }
        foreach (var tr in trains.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
        {
            Console.WriteLine($"Train: {tr.Key}");

            foreach (var pair in tr.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"###{pair.Key} - {pair.Value}");
            }
        }
    }
}

