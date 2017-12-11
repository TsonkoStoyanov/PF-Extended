using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class BigPower
{
    static void Main(string[] args)
    {
        BigInteger number  = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine(BigInteger.Pow(number,(int)number));
    }
}

