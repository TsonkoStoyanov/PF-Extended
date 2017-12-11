using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

class SoftuniCoffeeOrders
{
    static void Main()
    {
        int numberOfOrders = int.Parse(Console.ReadLine());
        decimal totalPrice = 0.0m;

        for (int i = 0; i < numberOfOrders; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            int qty = int.Parse(Console.ReadLine());
            int month = date.Month;
            int year = date.Year;
            int dateInMonts = DateTime.DaysInMonth(year, month);

            decimal price = dateInMonts * (pricePerCapsule * qty);

            Console.WriteLine($"The price for the coffee is: ${price:f2}");

            totalPrice += price;
        }
        Console.WriteLine($"Total: ${totalPrice:f2}");
    }
}
