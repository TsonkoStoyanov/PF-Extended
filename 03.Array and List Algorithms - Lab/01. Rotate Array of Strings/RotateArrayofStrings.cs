using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RotateArrayofStrings
{
    static void Main()
    {
        string[] arr = Console.ReadLine()
            .Split();

        string temp = arr[arr.Length-1];
        for (int i = arr.Length - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[0] = temp;

        Console.WriteLine(string.Join(" ", arr));
    }
}
