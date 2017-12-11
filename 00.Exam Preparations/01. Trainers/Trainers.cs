using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trainers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal technical = 0;
        decimal theoretical = 0;
        decimal practical = 0;
        decimal maxMoney = 0;
        string maxTeam = string.Empty;

        for (int i = 0; i < n; i++)
        {
            decimal distance = decimal.Parse(Console.ReadLine());

            decimal cargo = decimal.Parse(Console.ReadLine());

            string team = Console.ReadLine();

            decimal distanceInMeters = distance * 1600;

            decimal cargoInKillograms = cargo * 1000;

            decimal fuelExpense = (0.7m * distanceInMeters) * 2.5m;

            decimal participantEarnedMoney = (cargoInKillograms * 1.5m) - fuelExpense;

            switch (team)
            {
                case "Technical":
                    technical += participantEarnedMoney;
                    break;
                case "Theoretical":
                    theoretical += participantEarnedMoney;
                    break;
                case "Practical":
                    practical += participantEarnedMoney;
                    break;
            }
            if (technical > theoretical)
            {
                if (technical > practical)
                {
                    maxMoney = technical;
                    maxTeam = "Technical";
                }
                else
                {
                    maxMoney = practical;
                    maxTeam = "Practical";

                }
            }
            else
            {
                if (theoretical > practical)
                {
                    maxMoney = theoretical;
                    maxTeam = "Theoretical";
                }
                else
                {
                    maxMoney = practical;
                    maxTeam = "Practical";

                }
            }
        }
        Console.WriteLine($"The {maxTeam} Trainers win with ${maxMoney:f3}.");
    }
}
