using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HogwartsSorting
{
    static void Main()
    {
        int newcomers = Int32.Parse(Console.ReadLine());
        int countGryffindor = 0;
        int countSlytherin = 0;
        int countRavenclaw = 0;
        int countHufflepuff = 0;

        for (int i = 0; i < newcomers; i++)
        {
            int nameSum = 0;
            string[] input = Console.ReadLine().Split();
            string firstName = input[0];
            string lastName = input[1];
            string initials = $"{firstName.First()}{lastName.First()}";

            for (int j = 0; j < firstName.Length; j++)
            {
                nameSum += firstName[j];
            }
            for (int k = 0; k < lastName.Length; k++)
            {
                nameSum += lastName[k];
            }
            int reminder = nameSum % 4;
            switch (reminder)
            {
                case 0:
                    Console.WriteLine($"Gryffindor {nameSum + initials}");
                    countGryffindor++;
                    break;
                case 1:
                    Console.WriteLine($"Slytherin {nameSum + initials}");
                    countSlytherin++;
                    break;
                case 2:
                    Console.WriteLine($"Ravenclaw {nameSum + initials}");
                    countRavenclaw++;
                    break;
                case 3:
                    Console.WriteLine($"Hufflepuff {nameSum + initials}");
                    countHufflepuff++;
                    break;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Gryffindor: {countGryffindor}");
        Console.WriteLine($"Slytherin: {countSlytherin}");
        Console.WriteLine($"Ravenclaw: {countRavenclaw}");
        Console.WriteLine($"Hufflepuff: {countHufflepuff}");
    }
}
