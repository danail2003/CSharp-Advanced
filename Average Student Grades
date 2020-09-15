using System;
using System.Linq;
using System.Collections.Generic;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                string[] student = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!grades.ContainsKey(student[0]))
                {
                    grades[student[0]] = new List<decimal>();
                }

                grades[student[0]].Add(decimal.Parse(student[1]));
            }

            foreach (var student in grades)
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
}
