using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class AnonymousDownsite
{
    static void Main()
    {
        int downWebsites = int.Parse(Console.ReadLine());
        int securityKey = int.Parse(Console.ReadLine());

        List<string> sites = new List<string>();
        decimal totalPrice = 0.0m;

        for (int currentSite = 0; currentSite < downWebsites; currentSite++)
        {
            string[] input = Console.ReadLine().Split();
            string siteName = input[0];
            uint siteVisits = uint.Parse(input[1]);
            decimal pricePerVisit = decimal.Parse(input[2]);

            sites.Add(siteName);
            totalPrice += siteVisits * pricePerVisit;
        }
        foreach (var site in sites)
        {
            Console.WriteLine(site);
        }
        Console.WriteLine($"Total Loss: {totalPrice:f20}");
        Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey,downWebsites)}");
    }
}

