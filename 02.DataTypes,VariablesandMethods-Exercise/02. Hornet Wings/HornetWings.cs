using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HornetWings
{
    static void Main()
    {
        int wingFlaps = int.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());

        int endurance = int.Parse(Console.ReadLine()); //5 sec break

        double distanceFly = (wingFlaps / 1000) * distance;
        long time = (wingFlaps / 100) + (wingFlaps / endurance) * 5;

        Console.WriteLine($"{distanceFly:f2} m.");
        Console.WriteLine($"{time} s.");
    }
}

