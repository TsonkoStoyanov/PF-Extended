using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mid = n;
        int leftRight = 0;


        //top
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(
                $@"{new string('-', leftRight)}\{new string('-', mid)}|{new string('-', mid)}/{
                        new string('-', leftRight)
                    }");
            mid -= 2;
            leftRight += 2;
            Console.WriteLine();
        }
        leftRight = n;
        mid = 1;
        for (int i = 0; i <= n / 2; i++)
        {
            Console.Write($@"{new string('-', leftRight)}#{new string('.', mid)}#{new string('-', leftRight)}");
            mid += 4;
            leftRight -= 2;
            Console.WriteLine();
        }
        mid -= 2;
        Console.WriteLine($"#{new string('.', mid)}#");
        mid -= 2;
        leftRight += 2;
        for (int i = 0; i < n; i++)
        {
            Console.Write($@"{new string('-', leftRight)}#{new string('.', mid)}#{new string('-', leftRight)}");
            mid -=2 ;
            leftRight++;
            Console.WriteLine();
        }

    }
}

