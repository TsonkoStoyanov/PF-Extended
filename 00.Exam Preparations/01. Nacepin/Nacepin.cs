using System;
using System.Runtime.InteropServices;

class Nacepin
{
    static void Main(string[] args)
    {
        decimal priceUS = decimal.Parse(Console.ReadLine());
        long weigthUS = long.Parse(Console.ReadLine());
        decimal priceUK = decimal.Parse(Console.ReadLine());
        long weigthUK = long.Parse(Console.ReadLine());
        decimal priceChina = decimal.Parse(Console.ReadLine());
        long weigthChina = long.Parse(Console.ReadLine());

        decimal priceUSLeva = (priceUS / 0.58m) / weigthUS;
        decimal priceUKLeva = (priceUK / 0.41m) / weigthUK;
        decimal priceChinaLeva = (priceChina * 0.27m) / weigthChina;
        string stores = String.Empty;
        decimal min = 0;
        decimal max = Math.Max(priceChinaLeva, Math.Max(priceUKLeva, priceUSLeva));

        if (priceUSLeva<priceUKLeva)
        {
            if (priceUSLeva<priceChinaLeva)
            {
                min = priceUSLeva;
                stores = "US";
            }
            else
            {
                min = priceChinaLeva;
                stores = "Chinese";
            }
        }
        else
        {
            if (priceUSLeva < priceChinaLeva)
            {
                min = priceUKLeva;
                stores = "UK";
            }
            else
            {
                min = priceChinaLeva;
                stores = "Chinese";
            }
        }

        Console.WriteLine($"{stores} store. {min:f2} lv/kg");
        Console.WriteLine($"Difference {max - min:f2} lv/kg");
    }
}

