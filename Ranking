using System;
using System.Linq;
using System.Collections.Generic;

namespace Ranking
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, int>>> studentsRanking = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
            string contest = Console.ReadLine();

            while (contest != "end of contests")
            {
                string[] token = contest.Split(":");

                studentsRanking[token[0]] = new Dictionary<string, Dictionary<string, int>>();
                studentsRanking[token[0]][token[1]] = new Dictionary<string, int>();

                contest = Console.ReadLine();
            }

            string students = Console.ReadLine();

            while (students != "end of submissions")
            {
                string[] parts = students.Split("=>");

                if (studentsRanking.ContainsKey(parts[0]) && studentsRanking[parts[0]].ContainsKey(parts[1]))
                {
                    if (!studentsRanking[parts[0]][parts[1]].ContainsKey(parts[2]))
                    {
                        studentsRanking[parts[0]][parts[1]].Add(parts[2], int.Parse(parts[3]));
                    }

                    if (studentsRanking[parts[0]][parts[1]][parts[2]] < int.Parse(parts[3]))
                    {
                        studentsRanking[parts[0]][parts[1]][parts[2]] = int.Parse(parts[3]);
                    }
                }

                students = Console.ReadLine();
            }

            Dictionary<string, int> maxPoints = new Dictionary<string, int>();

            foreach (var course in studentsRanking)
            {
                foreach (var candidate in course.Value)
                {
                    foreach (var result in candidate.Value)
                    {
                        if (!maxPoints.ContainsKey(result.Key))
                        {
                            maxPoints[result.Key] = 0;
                        }

                        maxPoints[result.Key] += result.Value;
                    }
                }
            }

            int counter = 0;

            foreach (var member in maxPoints.OrderByDescending(x => x.Value))
            {
                if (counter < 1)
                {
                    Console.WriteLine($"Best candidate is {member.Key} with total {member.Value} points.");
                    counter++;
                }
            }

            Console.WriteLine("Ranking:");
            Dictionary<string, Dictionary<string, int>> keyValuePairs = new Dictionary<string, Dictionary<string, int>>();

            foreach (var subject in studentsRanking)
            {
                foreach (var pass in subject.Value)
                {
                    foreach (var member in pass.Value)
                    {
                        if (!keyValuePairs.ContainsKey(member.Key))
                        {
                            keyValuePairs[member.Key] = new Dictionary<string, int>();
                        }

                        keyValuePairs[member.Key].Add(subject.Key, member.Value);
                    }
                }
            }

            foreach (var user in keyValuePairs.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var points in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }
        }
    }
}
