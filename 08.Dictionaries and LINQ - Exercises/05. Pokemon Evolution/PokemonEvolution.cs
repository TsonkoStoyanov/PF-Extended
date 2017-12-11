using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = string.Empty;

        var pokemons = new Dictionary<string, List<KeyValuePair<string, long>>>();

        while ((input = Console.ReadLine()) != "wubbalubbadubdub")
        {
            string[] tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            string pokemonName = tokens[0];
            if (tokens.Length == 1)
            {
                if (pokemons.ContainsKey(pokemonName))
                {
                    Console.WriteLine($"# {pokemonName}");
                    foreach (var item in pokemons[pokemonName])
                    {
                        Console.WriteLine($"{item.Key} <-> {item.Value}");
                    }
                }
            }
            else
            {
                string evolutionType = tokens[1];
                long evolutionIndex = long.Parse(tokens[2]);

                if (!pokemons.ContainsKey(pokemonName))
                {
                    pokemons[pokemonName] = new List<KeyValuePair<string, long>>();
                }
                pokemons[pokemonName].Add(new KeyValuePair<string, long>(evolutionType, evolutionIndex));
            }
        }
        foreach (var itemPokemon in pokemons)
        {
            Console.WriteLine($"# {itemPokemon.Key}");
            foreach (var item in itemPokemon.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{ item.Key} <-> { item.Value}");
            }
        }
    }
}
