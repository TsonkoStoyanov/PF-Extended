using System;

class Wormtest
{
    static void Main()
    {
        long wormLength = long.Parse(Console.ReadLine());
        double wormWidth = double.Parse(Console.ReadLine());

        wormLength *= 100;

        if (wormWidth != 0)
        {
            if (wormLength % wormWidth == 0)
            {               
                Console.WriteLine($"{wormLength * wormWidth:f2}");
            }
            else
            {
                Console.WriteLine($"{(wormLength / wormWidth) * 100:f2}%");
            }
        }
        else
        {
            Console.WriteLine($"{wormLength * wormWidth:f2}");
        }
    }
}

