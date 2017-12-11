using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SweetDessert
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int guest = Int32.Parse(Console.ReadLine());
        decimal priceBanana = decimal.Parse(Console.ReadLine());   //1pcs
        decimal priceEgg = decimal.Parse(Console.ReadLine());       //1pcs
        decimal priceBerries = decimal.Parse(Console.ReadLine());   //1kg

        // 2 bananas, 4 eggs and 0.2 for 6 guest or 1 portions 

        int portions = guest / 6;

        if (guest % 6 != 0 )
        {
            portions++;
        }

        decimal moneyNeeded = (portions * (2 * priceBanana)) + (portions * (4 * priceEgg))
                              + (portions * (0.2m * priceBerries));

        if (moneyNeeded <= cash)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded-cash:f2}lv more.");
        }

    }
}

