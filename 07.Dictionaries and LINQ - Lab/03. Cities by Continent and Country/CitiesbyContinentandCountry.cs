using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CitiesbyContinentandCountry
{
    static void Main()
    {
        var data = new Dictionary<string, Dictionary<string, List<string>>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            string continent = input[0];
            string country = input[1];
            string city = input[2];


            if (!data.ContainsKey(continent))
            {
                data[continent] = new Dictionary<string, List<string>>();
            }
            if (!data[continent].ContainsKey(country))
            {
                data[continent][country] = new List<string>();
            }
            data[continent][country].Add(city);
        }
        foreach (var continents in data)
        {
            Console.WriteLine($"{continents.Key}:");
            foreach (var countries in continents.Value)
            {
                Console.Write($"  {countries.Key} -> ");
                Console.WriteLine(String.Join(", ", countries.Value));
            }
        }
    }
}
