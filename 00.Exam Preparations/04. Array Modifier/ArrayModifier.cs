using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Modifier
{
    class ArrayModifier
    {
        static void Main()
        {
            long[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            string input = String.Empty;
            ;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];
                int index1 = 0;
                int index2 = 0;
                if (inputArgs.Length>1)
                {
                    index1 = int.Parse(inputArgs[1]);
                    index2 = int.Parse(inputArgs[2]);

                }
                switch (command)
                {
                    case "swap":
                        SwapValue(arr, index1, index2);
                        break;
                    case "multiply":
                        MultiplyValue(arr, index1, index2);
                        break;
                    case "decrease":
                        Decrease(arr);
                        break;
                }

            }
            Console.WriteLine(string.Join(", ", arr));

        }

        private static void Decrease(long[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] -= 1;
            }
        }

        private static void MultiplyValue(long[] arr, int index1, int index2)
        {
            arr[index1] *= arr[index2];
        }

        private static void SwapValue(long[] arr, int index1, int index2)
        {
            long temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
