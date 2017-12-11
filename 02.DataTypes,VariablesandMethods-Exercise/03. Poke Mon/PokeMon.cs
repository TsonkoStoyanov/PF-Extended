using System;

class PokeMon
{
    static void Main()
    {
        int pokePower = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());

        double halfPokePower = pokePower * 0.50;
        int count = 0;

        while (pokePower >= distance)
        {
            pokePower -= distance;
            count++;
            if (pokePower==halfPokePower && exhaustionFactor !=0)
            {
                pokePower /= exhaustionFactor;
            }
        }
        Console.WriteLine(pokePower);
        Console.WriteLine(count);
    }
}
