using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FootballLeague
{
    static void Main()
    {
        string key = Console.ReadLine();
        string input = string.Empty;
        Dictionary<string, long> teamScores = new Dictionary<string, long>();
        Dictionary<string, long> teamGoals = new Dictionary<string, long>();

        while ((input = Console.ReadLine()) != "final")
        {
            string[] inputArgs = input.Split();
            string teamA = inputArgs[0];
            int startIndex = teamA.IndexOf(key);
            int endIndex = teamA.LastIndexOf(key);
            string homeTeam = teamA.Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
            char[] homeTeamArray = homeTeam.ToUpper().ToCharArray();
            Array.Reverse(homeTeamArray);
            homeTeam = new string(homeTeamArray);

            string decryptedAwayTeam = inputArgs[1];
            startIndex = decryptedAwayTeam.IndexOf(key);
            endIndex = decryptedAwayTeam.LastIndexOf(key);
            string awayTeam = decryptedAwayTeam.Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
            char[] awayTeamArray = awayTeam.ToUpper().ToCharArray();
            Array.Reverse(awayTeamArray);
            awayTeam = new string(awayTeamArray);

            string[] scores = inputArgs[2].Split(':');
            long scoreTeamA = long.Parse(scores[0]);
            long scoreTeamB = long.Parse(scores[1]);

            long pointsA = 0;
            long pointsB = 0;

            if (scoreTeamA>scoreTeamB)
            {
                pointsA = 3;
            }
            else if(scoreTeamA < scoreTeamB)
            {
                pointsB = 3;
            }
            else
            {
                pointsA = 1;
                pointsB = 1;
            }
            if (!teamScores.ContainsKey(homeTeam))
            {
                teamScores[homeTeam] = 0;                
            }
            teamScores[homeTeam] += pointsA;
            if (!teamGoals.ContainsKey(homeTeam))
            {
                teamGoals[homeTeam] = 0;
            }
            teamGoals[homeTeam] += scoreTeamA;
            if (!teamScores.ContainsKey(awayTeam))
            {
                teamScores[awayTeam] = 0;               
            }
            teamScores[awayTeam] += pointsB;
            if (!teamGoals.ContainsKey(awayTeam))
            {
                teamGoals[awayTeam] = 0;
            }
            teamGoals[awayTeam] += scoreTeamB;
        }
        int count = 0;

        Console.WriteLine($"League standings:");

        foreach (var team in teamScores
            .OrderByDescending(x=>x.Value)
            .ThenBy(y=>y.Key))
        {            
            count++;
            Console.WriteLine($"{count}. {team.Key} {team.Value}");
        }

        var orderedTeamGoals = teamGoals
            .OrderByDescending(x => x.Value)
            .ThenBy(y => y.Key)
            .Take(3);

        Console.WriteLine($"Top 3 scored goals:");

        foreach (var teamGoal in orderedTeamGoals)
        {
            Console.WriteLine($"- {teamGoal.Key} -> {teamGoal.Value}");
        }
    }
}
