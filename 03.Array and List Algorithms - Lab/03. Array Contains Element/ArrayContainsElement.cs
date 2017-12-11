using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayContainsElement
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int numbers = int.Parse(Console.ReadLine());
         bool isFind = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]==numbers)
            {
                isFind = true;
                break;
            }
        }
        if (isFind)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}
