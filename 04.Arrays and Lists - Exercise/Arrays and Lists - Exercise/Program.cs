using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> arr = Console.ReadLine()
            .Split().ToList();

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "3:1")
        {
            string[] inputArgs = input.Split();

            string command = inputArgs[0];

            if (command == "merge")
            {
                GetMegre(arr, inputArgs);
            }
            else if (command == "divide")
            {
                GetDivide(arr, inputArgs);
            }

        }
        Console.WriteLine(string.Join(" ", arr));
    }

    private static void GetDivide(List<string> arr, string[] inputArgs)
    {
        List<string> result = new List<string>();

        int index = int.Parse(inputArgs[1]);
        int partitions = int.Parse(inputArgs[2]);

        int subPartitions = arr[index].Length / partitions;

        for (int i = 0; i < partitions; i++)
        {

            if (i == partitions - 1)
            {

                result.Add(arr[index].Substring(i * subPartitions));
            }
            else
            {
                result.Add(arr[index].Substring(i * subPartitions, subPartitions));
            }
        }
        arr.RemoveAt(index);
        arr.InsertRange(index, result);
    }

    private static void GetMegre(List<string> arr, string[] inputArgs)
    {


        int startIndex = int.Parse(inputArgs[1]);
        int endIndex = int.Parse(inputArgs[2]);
        StringBuilder sb = new StringBuilder();

        if (startIndex < 0 || startIndex >= arr.Count)
        {
            startIndex = 0;
        }
        if (endIndex >= arr.Count)
        {
            endIndex = arr.Count - 1;
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            sb.Append(arr[i]);
        }
        arr.RemoveRange(startIndex, endIndex - startIndex + 1);

        arr.Insert(startIndex, sb.ToString());

    }

}