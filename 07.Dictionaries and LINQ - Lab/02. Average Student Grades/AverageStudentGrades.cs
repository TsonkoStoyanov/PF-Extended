using System;
using System.Collections.Generic;
using System.Linq;


class AverageStudentGrades
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> journal = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            double grade = double.Parse(input[1]);

            if (!journal.ContainsKey(name))
            {
                journal.Add(name, new List<double>());
            }
            journal[name].Add(grade);
        }

        foreach (var student in journal)
        {
            Console.Write($"{student.Key} -> ");

            foreach (var grade in student.Value)
            {
                Console.Write($"{grade:f2} ");
            }
            Console.WriteLine($"(avg: {student.Value.Average():f2})");
        }
    }
}
