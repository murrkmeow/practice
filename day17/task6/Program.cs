using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string marksFile = "mark.txt";
        string subjectsFile = "Subjects.txt";
        string outputFile = "averages.txt";

        var studentsData = File.ReadAllLines(marksFile)
                               .Select(line => line.Split(' '))
                               .Select(parts => new {
                                   Name = parts[0],
                                   Marks = parts.Skip(1).Select(int.Parse).ToArray()
                               })
                               .ToList();

        var subjects = File.ReadAllLines(subjectsFile);

        var topStudents = studentsData.Where(s => s.Marks.All(mark => mark >= 9))
                                      .Select(s => s.Name)
                                      .ToList();

        Console.WriteLine("Отличники:");
        topStudents.ForEach(Console.WriteLine);

        var subjectAverages = new Dictionary<string, double>();

        for (int i = 0; i < subjects.Length; i++)
        {
            double average = studentsData.Select(s => s.Marks[i]).Average();
            subjectAverages[subjects[i]] = average;
        }

        Console.WriteLine("\nСредние оценки по предметам:");
        foreach (var entry in subjectAverages)
            Console.WriteLine($"{entry.Key}: {entry.Value:F2}");

        var studentAverages = studentsData.Select(s => new {
            Name = s.Name,
            Average = s.Marks.Average()
        })
                                .OrderByDescending(s => s.Average)
                                .ToList();

        File.WriteAllLines(outputFile, studentAverages.Select(s => $"{s.Name}: {s.Average:F2}"));

        Console.WriteLine("\nФайл с упорядоченными средними баллами сохранен.");
    }
}
