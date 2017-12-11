using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Entertrain
{
    static void Main(string[] args)
    {
        int locomotivePower = int.Parse(Console.ReadLine());

        List<int> wagons = new List<int>();
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "All ofboard!")
        {
            int averageWeigth = 0;
            int wagonWeight = int.Parse(input);
            int indexToRemove = 0;
            int minDiference = int.MaxValue;

            wagons.Add(wagonWeight);

            if (wagons.Sum() > locomotivePower)
            {
                averageWeigth = wagons.Sum() / wagons.Count;
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (Math.Abs(wagons[i] - averageWeigth) < minDiference)
                    {
                        indexToRemove = i;
                        minDiference = Math.Abs(wagons[i] - averageWeigth);
                    }
                }
                wagons.RemoveAt(indexToRemove);
            }                                  
        }
        wagons.Insert(0, locomotivePower);
        wagons.Reverse();
        Console.WriteLine(string.Join(" ", wagons));
    }
}
