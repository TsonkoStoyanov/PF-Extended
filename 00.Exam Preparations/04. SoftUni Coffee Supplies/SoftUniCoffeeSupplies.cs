using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SoftUniCoffeeSupplies
{
    static void Main()
    {
        Dictionary<string, string> personCoffeeType = new Dictionary<string, string>();
        Dictionary<string, long> coffeeCount = new Dictionary<string, long>();

        string[] delimiters = Console.ReadLine().Split();

        string firstDelimiters = delimiters[0];
        string secondDelimiters = delimiters[1];

        string input = string.Empty;
        string personName = string.Empty;
        string coffeType = string.Empty;
        long quantity = 0;

        while ((input = Console.ReadLine()) != "end of info")
        {
            if (input.Contains(firstDelimiters))
            {
                string[] inputArgs = input.Split(new[] { firstDelimiters }, StringSplitOptions.RemoveEmptyEntries);

                personName = inputArgs[0];

                if (inputArgs.Length > 1)
                {
                    coffeType = inputArgs[1];
                }
                else
                {
                    continue;
                }

                if (!personCoffeeType.ContainsKey(personName))
                {
                    personCoffeeType[personName] = coffeType;
                }
                if (!coffeeCount.ContainsKey(coffeType))
                {
                    coffeeCount[coffeType] = 0;
                }
            }
            else if (input.Contains(secondDelimiters))
            {
                string[] inputArgs = input.Split(new[] { secondDelimiters }, StringSplitOptions.RemoveEmptyEntries);
                coffeType = inputArgs[0];
                quantity = long.Parse(inputArgs[1]); if (!coffeeCount.ContainsKey(coffeType))
                {
                    coffeeCount[coffeType] = 0;
                }
                coffeeCount[coffeType] += quantity;
            }
        }
        foreach (var cofee in coffeeCount.Where(x => x.Value <= 0))
        {
            Console.WriteLine($"Out of {cofee.Key}");
        }
        while ((input = Console.ReadLine()) != "end of week")
        {
            string[] inputArgs = input.Split();
            personName = inputArgs[0];
            quantity = long.Parse(inputArgs[1]);

            coffeType = personCoffeeType[personName];
            coffeeCount[coffeType] -= quantity;
            if (coffeeCount[coffeType] <= 0)
            {
                Console.WriteLine($"Out of {coffeType}");
            }
        }
        Console.WriteLine($"Coffee Left:");

        foreach (var remainingCoffee in coffeeCount
            .Where(x => x.Value > 0)
            .OrderByDescending(x => x.Value))

            Console.WriteLine(string.Join(" ", remainingCoffee.Key, remainingCoffee.Value));

        Console.WriteLine($"For:");

        foreach (string remainingCoffeeType in coffeeCount.Where(x => x.Value > 0)
            .OrderBy(x => x.Key)
            .Select(x => x.Key).ToList())
            foreach (string person in personCoffeeType.Where(x => x.Value == remainingCoffeeType)
                .OrderByDescending(x => x.Key)
                .Select(x => x.Key).ToList())
                Console.WriteLine($"{person} {remainingCoffeeType}");

    }
}
