using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayModifier
{
    static void Main()
    {
        long[] arr = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToArray();

        string input = String.Empty;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] inputArgs = input.Split();
            string command = inputArgs[0];

            int index1 = 0;
            int index2 = 0;

            if (inputArgs.Length > 1)
            {
                index1 = int.Parse(inputArgs[1]);
                index2 = int.Parse(inputArgs[2]);
            }

            switch (command)
            {
                case "swap":
                    SwapElements(arr, index1, index2);
                    break;
                case "multiply":
                    MultiplyElements(arr, index1, index2);
                    break;
                case "decrease":
                    DecreaseElements(arr, index1, index2);
                    break;
            }

        }
        Console.WriteLine(string.Join(", ", arr));
    }

    private static void DecreaseElements(long[] arr, int index1, int index2)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] -= 1;
        }
    }

    private static void MultiplyElements(long[] arr, int index1, int index2)
    {
        arr[index1] *= arr[index2];
    }

    private static void SwapElements(long[] arr, int index1, int index2)
    {
        long temp = arr[index2];
        arr[index2] = arr[index1];
        arr[index1] = temp;
    }
}

