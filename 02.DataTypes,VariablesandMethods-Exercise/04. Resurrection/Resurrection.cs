using System;

class Resurrection
{
    static void Main()
    {
        int phoenixes = int.Parse(Console.ReadLine());

        decimal totalYears = 0.00m;
        for (int i = 0; i < phoenixes; i++)
        {
            long bodyLength = long.Parse(Console.ReadLine());
            decimal bodyWidth = decimal.Parse(Console.ReadLine());
            int wing = int.Parse(Console.ReadLine());

            totalYears = (bodyLength * bodyLength) * (bodyWidth + (2 * wing));

            Console.WriteLine(totalYears);

        }
    }
}