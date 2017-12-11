using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Icarus
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int startingPosition = int.Parse(Console.ReadLine());

        string input = string.Empty;
        int icarusDamage = 1;
        int currentPosition = startingPosition;

        while ((input = Console.ReadLine()) != "Supernova")
        {
            string[] inputArgs = input.Split();
            string direction = inputArgs[0];
            int step = int.Parse(inputArgs[1]);

            if (direction == "left")
            {

                for (int currentStep = 0; currentStep < step; currentStep++)
                {
                    currentPosition--;
                    if (currentPosition < 0)
                    {
                        currentPosition = numbers.Length - 1;
                        icarusDamage++;
                    }
                    numbers[currentPosition] -= icarusDamage;
                }

            }
            else if (direction == "right")
            {
                for (int currentStep = 0; currentStep < step; currentStep++)
                {
                    currentPosition++;
                    if (currentPosition > numbers.Length - 1)
                    {
                        currentPosition = 0;
                        icarusDamage++;
                    }
                    numbers[currentPosition] -= icarusDamage;
                }
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}

